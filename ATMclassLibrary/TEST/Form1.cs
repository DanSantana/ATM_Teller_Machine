using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATMclassLibrary;
using System.IO;

namespace TEST
{
    public partial class Form1 : Form
    {
        atmManager atm = new atmManager();
        string saving;
        string checking;
        string cstinfo;


        public Form1()
        {
            InitializeComponent();
            atm.loadBank();
            atm.loadCustomer();
            loaddata();
            loadcus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = (Environment.CurrentDirectory).ToString();
        }

        public void loaddata()
        {
            try
            {
                foreach (Saving sv in atm.savingAccounts)
                {
                    saving += "S, "+ sv.pinnumber.ToString() + ", " + sv.acNumber.ToString()+", "+sv.acBalance.ToString()+Environment.NewLine;
                }
                foreach (Checking ch in atm.checkingAccounts)
                {
                    checking += "C, "+ch.pinnumber.ToString() + ", " + ch.acNumber.ToString()+", "+ch.acBalance.ToString()+Environment.NewLine;
                }
                txbSaving.Clear();
                txbSaving.Text = saving.ToString();
                txbChecking.Text = checking;
                txbbank.Text = "B, "+atm.bank.pinnumber.ToString()+", "+atm.bank.acBalance.ToString();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void loadcus()
        {
            foreach (Customer cu in atm.customersCollection)
            {
                cstinfo += cu.Name.ToString() + ", " + cu.pinNumber.ToString() + Environment.NewLine;
            }
            txbcustomers.Text = cstinfo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loaddata();
        }
        private void txbSaving_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbcustomers_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
