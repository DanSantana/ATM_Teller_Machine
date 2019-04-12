using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMclassLibrary
{
public class Saving : Account
{
// PROPERTIES AND FEATURES
// INTEREST RATE
private const decimal interestRate = 0.365m;//1%(balance*rate/365/100)
// CONSTRUCTORS
public Saving()
{

}
public Saving(string PIN, string acNo, decimal acBal) : base(PIN, acNo, acBal)
{

}
// ***METHODS***
// PAY INTEREST
public decimal payinterest()
{
acBalance = acBalance + interestRate;
return acBalance;
}
}
}
