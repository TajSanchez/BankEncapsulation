using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation;
public class BankAccount
{ 
    public string Name {  get; set; }
    public string Password { get; set; }


    private double _balance;
    

    public void Deposit(double myMoney)
    {
        _balance += myMoney;
    }

    public double GetBalance()
    {
        return _balance;
    }
}
