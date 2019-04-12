using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMclassLibrary
{
public class Checking : Account
{
// PROPERTIES AND FEATURES
// BILL FEE
public decimal billfee { get; set; }
// MAXIMUM BILL AMOUNT
private decimal _MaximumBillAmount;
public decimal MaxBillAmount
{
get { return _MaximumBillAmount; }
set { _MaximumBillAmount = value; }
}
// CONSTRUCTORs
public Checking()
{

}
public Checking(string PIN, string acNo, decimal acBal) : base(PIN, acNo, acBal)
{

}
// ***METHODS***
// PAY BILL
public bool paybill(decimal amount)
{
bool Paymentstatus = false;
acBalance = acBalance - amount - 1.25m;
return Paymentstatus;
}
}
}