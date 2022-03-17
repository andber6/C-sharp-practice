using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Sol
{
    public abstract class BankAccount
    {
        private string name;
        protected double balance = 0.0;

        public BankAccount(string name)
        {
            this.name = name;
        }

        public virtual void Deposit(double amount)
        {
            balance += amount;
        }

        public virtual void Withdraw(double amount)
        {
            balance -= amount;
        }

        public override string ToString()
        {
            return $"{name}, {balance:c}";
        }
    }
}
