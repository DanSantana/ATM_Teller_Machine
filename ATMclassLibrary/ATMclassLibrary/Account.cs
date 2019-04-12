using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Name: Dangelo Trindade Santana | dangelosantana@hotmail.com
// Professor: Lounis Zaidi | lounis.zaidi@collegecdi.ca
// Subject: Project Integration Level-1 PP1E
// Date: JAN-2017

namespace ATMclassLibrary
{
    public abstract class Account
    {
        // PROPERTIES AND FEATURES
        // PIN  NUMBER
        private string _pinnumber;
        public string pinnumber
        {
            get { return _pinnumber; }
            set { _pinnumber = value; }
        }
        // ACCOUNT NUMBER
        private string _acNumber;
        public string acNumber
        {
            get { return _acNumber; }
            set { _acNumber = value; }
        }
        // ACCOUNT BALANCE
        private decimal _acBalance;
        public decimal acBalance
        {
            get { return _acBalance; }
            set { _acBalance = value; }
        }
        // ACCOUNT MAXIMUM WITHDRAW
        private decimal _maxWithdraw;
        public decimal maxWithdraw
        {
            get { return _maxWithdraw; }
            set { _maxWithdraw = value; }
        }
        // ACCOUNT MAXIMUM TRANSFER AMOUNT
        private decimal _maxTransfer;
        public decimal maxtransfer
        {
            get { return _maxTransfer; }
            set { _maxTransfer = value; }
        }
        // CONSTRUCTOR
        public Account()
        {

        }
        public Account(string PIN, string acNo, decimal acBal, decimal acMaxdraw, decimal maxtransf)
        {
            pinnumber = PIN;
            acNumber = acNo;
            acBalance = acBal;
            maxWithdraw = acMaxdraw;
            maxtransfer = maxtransf;
        }
        public Account(string PIN, string acNo, decimal acBal)
        {
            pinnumber = PIN;
            acNumber = acNo;
            acBalance = acBal;
            maxWithdraw = 1000;
            maxtransfer = 10000;
        }
        // ***METHODS***
        // WITHDRAW
        public decimal withdraw(decimal wdAmount)
        {
            try
            {
                acBalance -= wdAmount;
            }
            catch (Exception e)
            { throw new Exception(e.Message); }
            return acBalance;
        }
        // DEPOSIT
        public decimal deposit(decimal creditAmount)
        {
            try
            {
                acBalance += creditAmount;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return acBalance;
        }
        // TRANSFER IN
        public decimal transferIN(decimal creditedamount)
        {
            try
            {
                acBalance += creditedamount;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return acBalance;
        }
        // TRANSFER OUT
        public decimal transferOUT(decimal debitedamount)
        {
            try
            {
                acBalance -= debitedamount;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return acBalance;
        }
        // GETPIN
        public string GetPin()
        {
            return pinnumber;
        }
        // GET ACCOUNT NUMBER
        public string GetAcNumber()
        {
            return acNumber;
        }
        // GETBALANCE
        public decimal GetBalance()
        {
            return acBalance;
        }
    }
}
