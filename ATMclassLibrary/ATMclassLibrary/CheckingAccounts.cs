using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ATMclassLibrary
{
    public class CheckingAccounts : CollectionBase
    {
        public void AddChecking(Checking Chck)
        {
            List.Add(Chck);
        }
        public Checking this[int i]
        {
            get
            {
                return (Checking)List[i];
            }
            set
            {
                List[i] = value;
            }
        }
    }
}
