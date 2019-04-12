using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMclassLibrary
{
    public class Customer
    {
        // PROPERTIES AND FEATURES
        // FIRST NAME
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        // PIN NUMBER
        private string _pinNumber;
        public string pinNumber
        {
            get { return _pinNumber; }
            set { _pinNumber = value; }
        }
        // CONSTRUCTOR
        public Customer()
        {

        }
        public Customer(string name, string PIN)
        {
            Name = name;
            pinNumber = PIN;
        }
        // GET NAME
        public string GetName()
        {
            return Name;
        }
        // GET PIN
        public string GetPIN()
        {
            return pinNumber;
        }
    }
}
