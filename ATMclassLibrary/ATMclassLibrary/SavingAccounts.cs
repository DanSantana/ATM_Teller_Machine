using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ATMclassLibrary
{
    public class SavingAccounts : CollectionBase
    {
        public void addSavin(Saving sv)
        {
            List.Add(sv);
        }
        public Saving this[int index]
        {
            get
            {
                return (Saving)this[index];
            }
            set
            {
                List[index] = value;
            }
        }
    }
}