using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMclassLibrary
{
    public class Bank : Account
    {
        public const decimal maximumTopUp = 20000.00m;
        public const decimal refillamount = 5000;
        // CONSTRUCTOR
        public Bank()
        {

        }
        public Bank(string PIN, string acNo, decimal acBal) : base(PIN, acNo, acBal)
        {

        }
        // *** METHODS ***
        // REFILL ATM
        public void refillATM()
        {
            try
            {
                while (acBalance+refillamount <= maximumTopUp)
                {
                    acBalance += refillamount;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
