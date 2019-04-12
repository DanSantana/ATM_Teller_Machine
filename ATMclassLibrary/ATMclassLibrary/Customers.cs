using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ATMclassLibrary
{
    public class Customers : CollectionBase
    {
        public void addCustomer(Customer customer)
        {
            List.Add(customer);
        }
        public Customer this[int i]
        {
            get
            {
                return (Customer)List[i];
            }
            set
            {
                List[i] = value;
            }
        }
    }
}