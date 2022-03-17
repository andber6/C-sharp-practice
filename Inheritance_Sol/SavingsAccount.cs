
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Sol
{
    public class SavingsAccount : BankAccount
    {
        private double interestRate;

        public SavingsAccount(string name, double interestRate) 
            : base(name)
        {
            this.interestRate = interestRate;
        }

        public void EarnInterest()
        {
            this.Deposit(balance * interestRate);
        }

        public override void Withdraw(double amount)
        {
            if (amount < balance)
            {
                base.Withdraw(amount);
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, interestRate: {interestRate}";
        }
    }
}
