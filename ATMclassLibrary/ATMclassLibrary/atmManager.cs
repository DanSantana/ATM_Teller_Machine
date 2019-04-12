using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Name: Dangelo Trindade Santana | dangelosantana@hotmail.com
// Professor: Lounis Zaidi | lounis.zaidi@collegecdi.ca
// Subject: Project Integration Level-1 PP1E
// Date: JAN-2017

namespace ATMclassLibrary
{
    public class atmManager
    {
        // BANK DEPLOYMENT
        public CheckingAccounts checkingAccounts = new CheckingAccounts();
        public SavingAccounts savingAccounts = new SavingAccounts();
        public Customers customers = new Customers();
        string currentPath = (Environment.CurrentDirectory);
        public Bank bank;
        
        // ACCOUNT
        public Checking checkingAccount = new Checking();
        public Saving savingAccount = new Saving();
        // CUSTOMER DEPLOYMENT
        public Customer customer = new Customer();
        // public Customers customersCollection = new Customers();
        // LOADING BANK INFO FILES
        public bool loadBank()
        {
            bool precessSucess = false;
            string PIN;
            string acNo;
            decimal acBal;
            try
            {
                string[] entries;
                string AccountsFile = (currentPath + "\\Accounts.txt");
                StreamReader streamReader = new StreamReader(AccountsFile);
                string line;
                line = streamReader.ReadLine();

                while (line != null)
                {
                    entries = line.Split(',');
                    if (entries[0] == "B")
                    {
                        PIN = (entries[1]).ToString();
                        acNo = (entries[2]).ToString();
                        acBal = Convert.ToDecimal(entries[3]);
                        bank = new Bank(PIN, acNo, acBal);
                        precessSucess = true;
                    }
                    else if (entries[0] == "C")
                    {
                        PIN = (entries[1]).ToString();
                        acNo = (entries[2]).ToString();
                        acBal = Convert.ToDecimal(entries[3]);
                        Checking checking = new Checking(PIN, acNo, acBal);
                        checkingAccounts.AddChecking(checking);
                    }
                    else if (entries[0] == "S")
                    {
                        PIN = (entries[1]).ToString();
                        acNo = (entries[2]).ToString();
                        acBal = Convert.ToDecimal(entries[3]);
                        Saving saving = new Saving(PIN, acNo, acBal);
                        savingAccounts.addSavin(saving);
                    }
                    line = streamReader.ReadLine();
                }
                streamReader.Close();
                precessSucess = true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return precessSucess;
        }
        // /READ CUSTOMERS (LOADING CUSTOMER INFO FILE )
        public bool loadCustomer()
        {
            string name;
            string Pin;
            string[] entries;
            string CustomerFile = (currentPath + "\\Customers.txt");
            StreamReader customerReader = new StreamReader(CustomerFile);
            string line;
            line = customerReader.ReadLine();
            bool precessSucess = false;
            try
            {
                while (line != null)
                {
                    entries = line.Split(',');
                    name = entries[0].ToString();
                    Pin = entries[1].ToString();
                    Customer cu = new Customer(name, Pin);
                    customers.addCustomer(cu);
                    line = customerReader.ReadLine();
                }
                customerReader.Close();
                precessSucess = true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return precessSucess;
        }
        // VALIDATE USER
        public bool validateUser(string name, string pin)
        {
            bool userOk = false;
            try
            {
                foreach (Customer Cust in customers)
                {
                    if (Cust.Name == name)
                    {
                        if (Cust.pinNumber == pin)
                        {
                            userOk = true;
                            customer = Cust;
                            loadsaving(Cust.pinNumber);
                            loadchecking(Cust.pinNumber);
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return userOk;
        }
        // READ ACCOUNTS CURRENT (LOAD CHECKING / LOAD SAVING)
        public bool loadsaving(string cuPin)
        {
            bool precessSucess = false;
            foreach (Saving sv in savingAccounts)
            {
                if (cuPin == sv.pinnumber)
                {
                    savingAccount = sv;
                    precessSucess = true;
                }
            }
            return precessSucess;
        }
        public bool loadchecking(string cuPin)
        {
            bool precessSucess = false;
            foreach (Checking chkacc in checkingAccounts)
            {
                if (cuPin == chkacc.pinnumber)
                {
                    checkingAccount = chkacc;
                    precessSucess = true;
                }
            }
            return precessSucess;
        }
        //WITHDRAW CHECKING
        public bool ChekingWithdraw(string pin, decimal amount)
        {
            bool ProcessPermission = false;
            decimal tencondiction = amount % 10;
            if (amount < 10000 && tencondiction == 0)
            {
                ProcessPermission = true;
                checkingAccount.withdraw(amount);
            }
            return ProcessPermission;
        }
        //WITHDRAW SAVINGS
        public bool savingWithdraw(string pin, decimal amount)
        {
            bool ProcessPermission = false;
            decimal tencondiction = amount % 10;
            if (amount < 10000 && tencondiction == 0)
            {
                ProcessPermission = true;
                savingAccount.withdraw(amount);
            }
            return ProcessPermission;
        }
        //DEPOSIT CHECKING
        public bool depositChecking(string pin, decimal amount)
        {
            bool processStatus = false;
            if (pin == checkingAccount.pinnumber)
            {
                checkingAccount.deposit(amount);
                processStatus = true;
            }
            return processStatus;
        }
        //DEPOSIT SAVINGS
        public bool depositsaving(string pin, decimal amount)
        {
            bool processStatus = false;
            if (pin == savingAccount.pinnumber)
            {
                savingAccount.deposit(amount);
                processStatus = true;
            }
            return processStatus;
        }
        //PAY BILL
        public bool paybill(string pin, decimal amount)
        {
            bool processok = false;
            decimal checkbalance = checkingAccount.acBalance - amount;
            if (pin == checkingAccount.pinnumber && checkbalance >= 0)
            {
                checkingAccount.paybill(amount);
                processok = true;
            }
            return processok;
        }
        //TRANSFER FUNDS
        public bool transferFunds(string pin, decimal amount, string TransferType)
        {
            bool processStatus = false;
            if (pin == customer.pinNumber)
            {
                decimal chekingenough = checkingAccount.acBalance - amount;
                decimal savingenough = savingAccount.acBalance - amount;
                if (TransferType == "CS" && chekingenough >= 0)//checking to save
                {
                    checkingAccount.transferOUT(amount);
                    savingAccount.transferIN(amount);
                    processStatus = true;
                }
                else if (TransferType == "SC" && savingenough >= 0)// saving to checking
                {
                    savingAccount.transferOUT(amount);
                    checkingAccount.transferIN(amount);
                    processStatus = true;
                }
            }
            return processStatus;
        }
        //DISPLAY ACCOUNT BALANCE
        public decimal DisplayCheckingBalance()
        {
            decimal balance = checkingAccount.acBalance;
            return balance;
        }
        public decimal DisplaySavingBalance()
        {
            decimal balance = savingAccount.acBalance;
            return balance;
        }
        //WRITEACCOUNTS
        public void WriteAccount()
        {
            try
            {
                string checkingInfo;
                string bankInfo;
                string savingInfo;
                string AccountsFile = (currentPath + "\\Accounts.txt");
                StreamWriter streamWriter = new StreamWriter(AccountsFile);

                bankInfo = "B," + bank.pinnumber.ToString() + "," + bank.acNumber.ToString() + "," + bank.acBalance.ToString();
                streamWriter.WriteLine(bankInfo);
                foreach (Checking check in checkingAccounts)
                {
                    checkingInfo = "C," + check.pinnumber.ToString() + ","+check.acNumber.ToString() + "," + check.acBalance.ToString();
                    streamWriter.WriteLine(checkingInfo);
                }
                foreach (Saving sv in savingAccounts)
                {
                    savingInfo = "S," + sv.pinnumber.ToString() + "," + sv.acNumber.ToString() + "," + sv.acBalance.ToString();
                    streamWriter.WriteLine(savingInfo);
                }
                streamWriter.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}