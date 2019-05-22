using System;
using System.Collections.Generic;
using System.IO;

namespace Banking
{
    internal class FileManager
    {
        protected string directory = @"C:\Bank\data\holders\";
        protected string account_directory = @"C:\Bank\data\accounts\";

        internal class Save : FileManager
        {
            internal void saveHolder(Holder h)
            {
                List<string> holderDetails = new List<string>();
                holderDetails.Add(h.getID().ToString());
                holderDetails.Add(h.getFirstName());
                holderDetails.Add(h.getLastName());
                holderDetails.Add(h.getPhone());
                holderDetails.Add(h.getEmail());
                holderDetails.Add(h.getAddress().getLineOne());
                holderDetails.Add(h.getAddress().getLineTwo());
                holderDetails.Add(h.getAddress().getCity());
                holderDetails.Add(h.getAddress().getState());
                holderDetails.Add(h.getAddress().getZip());
                holderDetails.Add(" ");
                foreach (Account a in h.getAccountList())
                {
                    holderDetails.Add(a.getAccountNumber().ToString());

                    //make new file about account
                    List<string> accountDetails = new List<string>();
                    if (a.isClosed())
                    {
                        accountDetails.Add("0");
                    }
                    if (!a.isClosed())
                    {
                        accountDetails.Add("1");
                    }
                    if (a.getAccountType() == AcctType.CHECKING)
                    {
                        accountDetails.Add("1");
                    }
                    if (a.getAccountType() == AcctType.SAVINGS)
                    {
                        accountDetails.Add("2");
                    }
                    accountDetails.Add(a.getAccountNumber().ToString());
                    string[] openingDate = { a.getOpenDate().Year.ToString(), a.getOpenDate().Month.ToString(), a.getOpenDate().Day.ToString() };
                    accountDetails.Add(string.Join(", ", openingDate));
                    accountDetails.Add(" ");
                    accountDetails.Add("<Activity Start 5>");
                    foreach (Activity act in a.getActivity())
                    {
                        string[] activityDetails = { act.Date.Year.ToString(), act.Date.Month.ToString(), act.Date.Day.ToString(), act.Type.ToString(), act.Amount.ToString(), act.getAdjustedValue().ToString() };
                        accountDetails.Add(string.Join(", ", activityDetails));
                    }

                    // Write the account details to a seperate file.
                    string acctSaveAs = account_directory + a.getAccountNumber() + "acct_file.txt";
                    StreamWriter acctFile = new StreamWriter(acctSaveAs);
                    foreach (string line in accountDetails)
                    {
                        acctFile.WriteLine(line);
                    }

                    acctFile.Close();
                }

                // Write the string to a file.
                string saveAs = directory + h.getID() + "holder_file.txt";
                StreamWriter file = new StreamWriter(saveAs);
                foreach (string line in holderDetails)
                {
                    file.WriteLine(line);
                }
                file.Close();
            }
        }

        internal class HolderImport : FileManager
        {
            private List<Holder> holderCollection;
            private Account account;

            internal void start()
            {
                List<string[]> lineCollection = new List<string[]>();
                holderCollection = new List<Holder>();
                string[] filePaths = Directory.GetFiles(directory, "*.txt");

                /* Get file information from directory to array */
                foreach (string file in filePaths)
                {
                    string[] newFile = File.ReadAllLines(file);
                    lineCollection.Add(newFile);
                }

                /* Get all customer information from each file */
                foreach (string[] l in lineCollection)
                {
                    Holder holder = new Holder();
                    holder.setID(long.Parse(l[0]));
                    holder.setPersonDetails(l[1], l[2], l[3], l[4]);
                    holder.setAddress(l[5], l[6], l[7], l[8], l[9]);

                    for (int i = 11; i < l.Length; i++)
                    {
                        var acct_num = l[i];
                        string[] accountInfoFromFile = File.ReadAllLines(account_directory + acct_num + "acct_file.txt");
                        
                        /* Get file and open */
                        if (int.Parse(accountInfoFromFile[1]) == 1)
                        {
                            account = new Checking();
                        }
                        if (int.Parse(accountInfoFromFile[1]) == 2)
                        {
                            account = new Savings();
                        }
                        if (int.Parse(accountInfoFromFile[0]) == 0)
                        {
                            account.closeAccount(true);
                        }
                        if (int.Parse(accountInfoFromFile[0]) == 1)
                        {
                            account.closeAccount(false);
                        }

                        account.setAccountNumber(long.Parse(accountInfoFromFile[2]));
                        string[] openDate = accountInfoFromFile[3].Split(',');
                        account.setOpenDate(new DateTime(int.Parse(openDate[0]), int.Parse(openDate[1]), int.Parse(openDate[2])));

                        for (int z = 6; z < accountInfoFromFile.Length; z++)
                        {
                            string[] activityLine = accountInfoFromFile[z].Split(',');
                            var activity = new Activity(new DateTime(int.Parse(activityLine[0]), int.Parse(activityLine[1]), int.Parse(activityLine[2])), (Type)Enum.Parse(typeof(Type), activityLine[3].ToUpper()), decimal.Parse(activityLine[4]));
                            activity.adjustActivity(Boolean.Parse(activityLine[5]));
                            account.newActivity(activity);
                        }
                        account.addNewAccountHolder(holder);
                        holder.addNewAccount(account);
                    }
                    holderCollection.Add(holder);
                }
            }

            internal List<Holder> getHolderCollection()
            {
                return holderCollection;
            }
        }
    }
}
