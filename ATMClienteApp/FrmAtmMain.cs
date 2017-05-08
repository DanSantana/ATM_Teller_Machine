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

namespace ATMClienteApp
{
    public partial class FrmAtmMain : Form
    {
        string pin;
        FrmLogin mylog;
        atmManager atm = new atmManager();
        decimal availabelATMmoney;
        //string currText;
        //string oldText;
        public FrmAtmMain(string PIN, FrmLogin MYLOG, atmManager ATM)
        {
            InitializeComponent();
            pin = PIN;
            mylog = MYLOG;
            atm = ATM;
        }
        private void btPayBill_Click(object sender, EventArgs e)
        {
            if (txbAmount.Text != null && txbAmount.Text != "")
            {
                decimal billvalue = Convert.ToDecimal(txbAmount.Text);
                if (billvalue > 10000)
                {
                    txbAccountinfo.Clear();
                    txbAccountinfo.Text = "The Pay Bill Transaction do not progress values upper to $10,000." + Environment.NewLine + Environment.NewLine + "Would Like to progress a new Transaction?";
                }
                else if (txbAmount.Text == null)
                {
                    txbAccountinfo.Clear();
                    txbAccountinfo.Text = Environment.NewLine + "Please enter the amount in order to progress this transaction";
                    riseNewtransaction();
                }
                else if (rdbtFromChecking.Checked == true)
                {
                    if (atm.checkingAccount.acBalance - 1.25m - billvalue < 0)
                    {
                        txbAccountinfo.Clear();
                        txbAccountinfo.Text = Environment.NewLine + "Sorry, There is not available money to progress this transaction." + Environment.NewLine;
                    }
                    else
                    {
                        atm.checkingAccount.paybill(billvalue);
                        txbAccountinfo.Clear();
                        txbAccountinfo.Text = Environment.NewLine + "Your payment Was successfully progressed." + Environment.NewLine + Environment.NewLine + "Thank you for use the ATM Teller MAchine.";
                        writeupdate();
                    }
                }
                else if (rdbtFromChecking.Checked != true)
                {
                    txbAccountinfo.Clear();
                    txbAccountinfo.Text = "The Pay Bill Transaction can only be progress from Checking Account." + Environment.NewLine + "please Select Checking Account, and try again";
                }
                riseNewtransaction();
            }
            else
            {
                txbAccountinfo.Clear();
                txbAccountinfo.Text = Environment.NewLine + "Please enter the amount in order to progress this transaction";
                riseNewtransaction();
            }
        }
        private void btCloseApp_Click(object sender, EventArgs e)
        {
            txbAccountinfo.Clear();
            txbAmount.Clear();
            atm.bank.acBalance = availabelATMmoney;
            writeupdate();
            this.Close();
            mylog.Show();
        }
        public void FrmAtmMain_Load(object sender, EventArgs e)
        {
            DisplayAccount();
            rdbtFromChecking.Checked = true;
            btNewTransaction.Hide();
            availabelATMmoney = atm.bank.acBalance;
            txbAmount.Focus();
        }
        private void btDeposit_Click(object sender, EventArgs e)
        {
            if (txbAmount.Text != null && txbAmount.Text != "")
            {
                decimal amount = Convert.ToDecimal(txbAmount.Text);
                if (rdbtFromChecking.Checked == true)
                {
                    atm.depositChecking(pin, amount);
                    txbAccountinfo.Text = "Deposit Authorized, Value: " + amount.ToString() + Environment.NewLine + " to checking Account:" + atm.checkingAccount.acNumber.ToString() + Environment.NewLine + Environment.NewLine + " Please Insert The Envelope!";
                    riseNewtransaction();
                    writeupdate();
                }

                else
                {
                    atm.depositsaving(pin, amount);
                    txbAccountinfo.Text = "Deposit Authorized, Value: " + amount.ToString() + Environment.NewLine + " to Saving Account:" + atm.savingAccount.acNumber.ToString() + Environment.NewLine + Environment.NewLine + " Please Insert The Envelope!";
                    riseNewtransaction();
                    writeupdate();
                }
            }
            else
            {
                txbAccountinfo.Clear();
                txbAccountinfo.Text = Environment.NewLine + "Please enter the amount in order to progress this transaction";
                riseNewtransaction();
            }
        }
        public void DisplayAccount()
        {
            txbAccountinfo.Clear();
            decimal chebal = atm.checkingAccount.acBalance;
            decimal savbal = atm.savingAccount.acBalance;
            decimal totbal = chebal + savbal;
            txbAccountinfo.Text = "       Welcome " + atm.customer.Name + Environment.NewLine + Environment.NewLine + " Checking Account [" + atm.checkingAccount.acNumber.ToString() + "]" + Environment.NewLine + " Current Balance: " + chebal.ToString() + Environment.NewLine + Environment.NewLine + " Saving Account [" + atm.savingAccount.acNumber.ToString() + "]" + Environment.NewLine + " Current Balance: " + savbal.ToString() + Environment.NewLine + Environment.NewLine + " Total amount disponible: " + totbal.ToString() + Environment.NewLine + Environment.NewLine + "In Order To Tranfer Funds Select: " + Environment.NewLine + "[] Checking → Checking to Saving Account;" + Environment.NewLine + "[] Saving   → Saving to Checking Account; ";
            txbAmount.Focus();
        }
        private void btWithdrawal_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(txbAmount.Text);
            if (amount % 10 != 0 || amount > 1000)
            {
                txbAccountinfo.Clear();
                txbAccountinfo.Text = Environment.NewLine + "Sorry, the amount entered must be a multiple of $10, Limited to $1000.00 for each transaction";
                riseNewtransaction();
            }
            else if (availabelATMmoney < amount)
            {
                txbAccountinfo.Clear();
                txbAccountinfo.Text = Environment.NewLine + "Sorry, there is not enough money available to progress this transaction ";
                riseNewtransaction();
            }
            else if (txbAmount.Text == null)
            {
                txbAccountinfo.Clear();
                txbAccountinfo.Text = Environment.NewLine + "Please enter the amount in order to progress this transaction";
                riseNewtransaction();
            }
            else if (rdbtFromChecking.Checked == true)
            {
                atm.ChekingWithdraw(pin, amount);
                availabelATMmoney -= amount;
                txbAccountinfo.Text = "Was withdrawn the amount of $" + amount + Environment.NewLine + "the Currfent Balance is: " + atm.checkingAccount.acBalance.ToString();
                riseNewtransaction();
            }
            else if (rdbtFromChecking.Checked == true)
            {
                atm.savingWithdraw(pin, amount);
                availabelATMmoney -= amount;
                txbAccountinfo.Text = "Was withdrawn the amount of $" + amount + Environment.NewLine + "the Current Balance is: " + atm.savingAccount.ToString();
                riseNewtransaction();
            }
        }
        public void riseNewtransaction()
        {
            btNewTransaction.Show();
            btDeposit.Hide();
            btPayBill.Hide();
            btWithdrawal.Hide();
            btTranfFunds.Hide();
            bgaccountSet.Enabled = false;
            bgAmount.Enabled = false;
            btNewTransaction.Focus();
        }
        private void btTranfFunds_Click(object sender, EventArgs e)
        {
            if (txbAmount.Text != null && txbAmount.Text != "")
            {
                txbAccountinfo.Clear();
                decimal checbal = atm.checkingAccount.acBalance;
                decimal savbal = atm.savingAccount.acBalance;
                decimal amount = Convert.ToDecimal(txbAmount.Text);
                if (amount > 100000)
                {
                    txbAccountinfo.Text = Environment.NewLine + "Sorry, the amount transaction is Limited to $100,000.00";
                    riseNewtransaction();
                }
                else if (txbAmount.Text == null)
                {
                    txbAccountinfo.Clear();
                    txbAccountinfo.Text = Environment.NewLine + "Please enter the amount in order to progress this transaction";
                    riseNewtransaction();
                }
                else if (rdbtFromChecking.Checked == true)
                {
                    if (checbal - amount < 0)
                    {
                        txbAccountinfo.Text = Environment.NewLine + "Sorry, there is not enough balance to progress this transaction";
                        riseNewtransaction();
                    }
                    else
                    {
                        atm.transferFunds(pin, amount, "CS");
                        txbAccountinfo.Text = Environment.NewLine + "Transfer transaction successfully progressed" + Environment.NewLine + Environment.NewLine + "New Checking Balance: " + atm.checkingAccount.acBalance.ToString() + Environment.NewLine + Environment.NewLine + "New Saving Balance: " + atm.savingAccount.acBalance.ToString();
                        riseNewtransaction();
                        writeupdate();
                    }
                }
                else if (rdbtFromSaving.Checked == true)
                {
                    if (savbal - amount < 0)
                    {
                        txbAccountinfo.Text = Environment.NewLine + "Sorry, there is not enough balance to progress this transaction";
                        riseNewtransaction();
                        writeupdate();
                    }
                    else
                    {
                        atm.transferFunds(pin, amount, "SC");
                        riseNewtransaction();
                        txbAccountinfo.Text = Environment.NewLine + "Transfer transaction successfully progressed" + Environment.NewLine + Environment.NewLine + "New Checking Balance: " + atm.checkingAccount.acBalance.ToString() + Environment.NewLine + Environment.NewLine + "New Saving Balance: " + atm.savingAccount.acBalance.ToString();
                        riseNewtransaction();
                        writeupdate();
                    }
                }
            }
            else
            {
                txbAccountinfo.Clear();
                txbAccountinfo.Text = Environment.NewLine + "Please enter the amount in order to progress this transaction";
                riseNewtransaction();
            }
        }
        private void btNewTransaction_Click_1(object sender, EventArgs e)
        {
            writeupdate();
            txbAmount.Clear();
            DisplayAccount();
            btNewTransaction.Hide();
            btDeposit.Show();
            btPayBill.Show();
            btWithdrawal.Show();
            btTranfFunds.Show();
            bgaccountSet.Enabled = true;
            bgAmount.Enabled = true;
            txbAmount.Focus();
        }
        private void txbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if ((char)e.KeyChar != '.' && e.KeyChar != 8)
                    e.Handled = true;
            }
            if (e.KeyChar == '.' && this.txbAmount.Text.IndexOf('.') >= 0)
                e.Handled = true;
            int index = this.txbAmount.Text.IndexOf('.');
            if (index >= 0)
            {
                string Size = this.txbAmount.Text.Substring(index);
                if (Size.Length > 2 && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }
        private void txbAmount_TextChanged(object sender, EventArgs e)
        {
        }
        private ClassMasc deploymasc(char charac, string text)
        {
            // not deployed or used yet
            ClassMasc mascobject = new ClassMasc();
            mascobject.receiveKey(charac);
            mascobject.ReceiveWord(text);
            return mascobject;
        }
        private void txbAmount_Click(object sender, EventArgs e)
        {
            txbAmount.SelectionStart = txbAmount.Text.Length + 1;
        }
        private void btWithdrawal_Click_1(object sender, EventArgs e)
        {
            if (txbAmount.Text != null && txbAmount.Text != "")
            {
                decimal amount = Convert.ToDecimal(txbAmount.Text);
                if (amount % 10 != 0 || amount > 1000)
                {
                    txbAccountinfo.Clear();
                    txbAccountinfo.Text = Environment.NewLine + "Sorry, the amount entered must be a multiple of $10, Limited to $1000.00 for each transaction";
                    riseNewtransaction();
                }
                else if (availabelATMmoney < amount)
                {
                    txbAccountinfo.Clear();
                    txbAccountinfo.Text = Environment.NewLine + "Sorry, there is not enough money available to progress this transaction ";
                    riseNewtransaction();
                }
                else if (rdbtFromChecking.Checked == true)
                {
                    decimal WithDrawSimulation = atm.checkingAccount.acBalance - amount;
                    if (WithDrawSimulation >= 0)
                    {
                        atm.ChekingWithdraw(pin, amount);
                        availabelATMmoney -= amount;
                        txbAccountinfo.Text = "Was withdrawn the amount of $" + amount + Environment.NewLine + "the Currfent Balance is: " + atm.checkingAccount.acBalance.ToString();
                        riseNewtransaction();
                        atm.bank.acBalance = availabelATMmoney;
                        writeupdate();
                    }
                    else
                    {
                        txbAccountinfo.Text = "  There is not availabel money at your account to progress this operation" + amount + Environment.NewLine + "the Currfent Balance is: " + atm.checkingAccount.acBalance.ToString();
                        riseNewtransaction();
                    }
                }
                else if (rdbtFromSaving.Checked == true)
                {
                    decimal WithDrawSimulation = atm.checkingAccount.acBalance - amount;
                    if (WithDrawSimulation >= 0)
                    {
                        atm.savingWithdraw(pin, amount);
                        availabelATMmoney -= amount;
                        txbAccountinfo.Text = "Was withdrawn the amount of $" + amount + Environment.NewLine + "the Current Balance is: " + atm.savingAccount.acBalance.ToString();
                        riseNewtransaction();
                        atm.bank.acBalance = availabelATMmoney;
                        writeupdate();
                    }
                    else
                    {
                        txbAccountinfo.Text = "  There is not availabel money at your account to progress this operation" + amount + Environment.NewLine + "the Currfent Balance is: " + atm.checkingAccount.acBalance.ToString();
                        riseNewtransaction();
                    }
                }
            }
            else
            {
                txbAccountinfo.Clear();
                txbAccountinfo.Text = Environment.NewLine + "Please enter the amount in order to progress this transaction";
                riseNewtransaction();
            }
        }
        public void writeupdate()
        {
            atm.WriteAccount();
        }
        private void bttestwrite_Click(object sender, EventArgs e)
        {
            writeupdate();
        }
        private void txbAmount_ImeModeChanged(object sender, EventArgs e)
        {
        }
        public void validateAmount()
        {
            if (txbAmount.Text == null || txbAmount.Text == "")
            {
                txbAccountinfo.Clear();
                txbAccountinfo.Text = Environment.NewLine + "Please enter the amount in order to progress this transaction";
                riseNewtransaction();
            }
        }
    }
}
