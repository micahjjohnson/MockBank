using System;
using System.Linq;
using System.Windows.Forms;

namespace Banking
{
    public partial class PanelViewAllHolders : Form
    {
        private MasterForm master;
        private bool deleteMode;

        internal PanelViewAllHolders(MasterForm master)
        {
            InitializeComponent();
            this.master = master;

            var peopleList = master.getMasterBank().getBankServices().getAccountList().OrderBy(c => c.getAccountNumber());
            fill(peopleList);
        }
     
        internal Panel Panel { get { return panel1; } }

        internal void fill(IOrderedEnumerable<Account> list)
        {
            listView1.Items.Clear();
            string x;

            foreach (Account act in list)
            {
                if (act.isClosed())
                {
                    x = "CLOSED";
                }
                else
                {
                    x = "OPEN";
                }
                listView1.Items.Add(new ListViewItem(new string[6] { act.getAccountNumber().ToString(), x, 
                    act.getCardHolder(1).getFullName(), act.getAccountType().ToString(), act.getBalance().ToString("0.00"), act.getOpenDate().ToShortDateString() }));
            }
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem tsi = sender as ToolStripItem;

            if (tsi == ascendingToolStripMenuItem)
            {
                var peopleList = master.getMasterBank().getBankServices().getAccountList().OrderBy(c => c.getAccountNumber());
                fill(peopleList);
            }
            if (tsi == descendingToolStripMenuItem)
            {
                var peopleList = master.getMasterBank().getBankServices().getAccountList().OrderByDescending(c => c.getAccountNumber());
                fill(peopleList);
            }
            if (tsi == nameToolStripMenuItem)
            {
                var peopleList = master.getMasterBank().getBankServices().getAccountList().OrderBy(c => c.getCardHolder(1).getFullName());
                fill(peopleList);
            }
            if (tsi == ascendingToolStripMenuItem)
            {
                var peopleList = master.getMasterBank().getBankServices().getAccountList().OrderBy(c => c.getAccountType().ToString());
                fill(peopleList);
            }
            if (tsi == earliestFirstToolStripMenuItem1)
            {
                var peopleList = master.getMasterBank().getBankServices().getAccountList().OrderByDescending(c => c.getOpenDate());
                fill(peopleList);
            }
            if (tsi == oldestFirstToolStripMenuItem)
            {
                var peopleList = master.getMasterBank().getBankServices().getAccountList().OrderBy(c => c.getOpenDate());
                fill(peopleList);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (deleteMode)
                {
                    var confirm = new DialogConfirm();
                    confirm.setDialogText("Are you sure you want to delete this customer? This action cannot be undone.");
                    confirm.ShowDialog();

                    if (confirm.DialogResult == DialogResult.Yes)
                    {
                        //master.deleteUser();
                        deleteMode = false;
                    }
                }
                else
                {
                    var person = listView1.SelectedItems[0].Text;
                    var search = new Search.SearchThroughAccount();
                    search.ForExactAccountNumber(master.getMasterBank().getBankServices(), long.Parse(person));

                    master.setAccount(search.AccountSearchResults[0]);
                    master.updateView(1);
                }
           } catch { }
        }

        private void delete_toolStripButton1_Click(object sender, EventArgs e)
        {
            deleteMode = true;
        }
    }
}
