using System.Linq;

namespace Banking
{
    internal class MasterBank
    {
        private readonly AccountServices accountServices;
        private readonly BankResources bankResources;
        private readonly BankServices bankServices;

        public MasterBank()
        {
            bankResources = new BankResources();
            accountServices = new AccountServices(bankResources);
            bankServices = new BankServices(bankResources);

            /* Import Holders */
            FileManager.HolderImport holderImport = new FileManager.HolderImport();
            holderImport.start();

            foreach (Holder h in holderImport.getHolderCollection())
            {
                bankServices.newHolderForImport(h);
            }

            /* Order account list by Holder ID */
            var holderList = bankServices.getMasterHolderList().OrderBy(c => c.getID());
            var startingHolderID = holderList.Last().getID();
            bankResources.setHolderIDStarter(startingHolderID);

            /* Order account list by Account Number */
            var newList = bankServices.getAccountList().OrderBy(c => c.getAccountNumber());
            var startingAccountNumber = newList.Last().getAccountNumber();
            bankResources.setAccountNumStarter(startingAccountNumber);
        }

        internal void saveProgram()
        {
            foreach (Holder h in bankServices.getMasterHolderList())
            {
                FileManager.Save save = new FileManager.Save();
                save.saveHolder(h);
            }
        }

        internal AccountServices getAccountServices()
        {
            return accountServices;
        }

        internal BankServices getBankServices()
        {
            return bankServices;
        }

        internal BankResources getBankResources()
        {
            return bankResources;
        }
    }
}
