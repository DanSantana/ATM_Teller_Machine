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
using System.Threading;
using System.Diagnostics;

namespace ATMClienteApp
{
    public partial class FrmLogin : Form
    {
        int cnt = 1;
        public bool outofservice = false;
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            OutofServiceMode();
        }
        private void OutofServiceMode()
        {
            if (outofservice == false)
            {
                lboutofService.Visible = false;
                lbsorry.Visible = false;
            }
            else
            {
                lboutofService.Visible = true;
                lbsorry.Visible = true;
            }
        }
        public void btLogin_Click(object sender, EventArgs e)
        {
            atmManager atm = new atmManager();
            atm.loadBank();
            atm.loadCustomer();
            string name = txbName.Text;
            string pin = txbPin.Text;
            bool loginconfirm = atm.validateUser(name, pin);
            if (outofservice == false || name == "Korben Dallas")
            {
                if (txbName.Text == "" || txbPin.Text == "")
                {
                    MessageBox.Show("Please entry [Name] and [PApssword]", "Error: Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txbPin.Text = "";
                    this.txbName.Text = "";
                    txbPin.Clear();
                    txbName.Clear();
                }
                else if (loginconfirm == true && name != "Korben Dallas")
                {
                    this.txbPin.Text = "";
                    this.txbName.Text = "";
                    FrmAtmMain frmMain = new FrmAtmMain(pin, this, atm);
                    this.Hide();
                    frmMain.Show();
                    frmMain.Activate();
                }
                else if (loginconfirm == true && name == "Korben Dallas")
                {
                    this.txbPin.Text = "";
                    this.txbName.Text = "";
                    FrmAdmin frmAdmin = new FrmAdmin(pin, this, atm);
                    this.Hide();
                    frmAdmin.Show();
                    frmAdmin.Activate();
                }
                else if (loginconfirm == false && cnt < 3)
                {
                    cnt++;
                    MessageBox.Show("Sorry! \n The User or Password is incorrect", "Error: User || Passwor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbPin.Clear();
                }
                else if (loginconfirm == false && cnt >= 3)
                {
                    MessageBox.Show("Sorry! \n Was not possible access your account \n try again later, Thank you", "Error: User || Passwor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txbPin.Text = "";
                    this.txbName.Text = "";
                    txbPin.Clear();
                    txbName.Clear();
                }
            }
            else
            {
                txbName.Clear();
                txbPin.Clear();
                for (int i = 1; i < 5; i++)
                {
                    Thread.Sleep(1000);
                    Console.Beep();
                    lboutofService.Show();
                    lbsorry.Show();
                }
                lboutofService.Show();
                lbsorry.Show();
            }
        }
        private void btLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void txbPin_TextChanged(object sender, EventArgs e)
        {
        }
        private void txbPin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void txbtime_TextChanged(object sender, EventArgs e)
        {
        }
        private void lboutofService_Click(object sender, EventArgs e)
        {
        }

        private void btOpenManual_Click(object sender, EventArgs e)
        {
            string currentPath = (Environment.CurrentDirectory);
            string instructionFile = (currentPath + "\\ATM_instructions.pdf");
            System.Diagnostics.Process.Start(instructionFile);
        }
    }
}