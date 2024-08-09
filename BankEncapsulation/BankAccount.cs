using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
     class BankAccount
    {

        private double _balance = 0.00;
        //private int _accountID;
        //public string? FirstName { get; set; }
        //public string? AccountDescription { get; set; }
        
        public void Deposit(double depositAmount)
        {
            _balance += depositAmount;
        }

        public double GetBalance()
        {
            return _balance;
        }

    }
}
