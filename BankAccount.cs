using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Constructors__Methods__and_Overloading
{
    internal class BankAccount
    {
        string _accounNumber;
        string _name;
        double _balance;

        public BankAccount(string accounNumber, string name, double balance)
        {
            _accounNumber = accounNumber;
            _name = name;
            _balance = balance;
        }

        public string Name { get => _name; set => _name = value; }
        public string AccounNumber { get => _accounNumber; }
        public double Balance { get => _balance; }

        public void Deposit(double amount)
        {
           if(amount > 0) 
           {
                _balance += amount;
           }
           
        }
        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                _balance -= amount;
            }
            else if (amount > _balance)
            {
                _balance = Balance;
            }
           
        }
        public override string ToString()
        {
            return $"{_accounNumber} - {_name} - Current Balance {_balance.ToString("C")}";
        }
    }
}
