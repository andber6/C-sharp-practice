using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Sol
{
    public class CurrentAccount : BankAccount
    {
        private List<double> directDebits = new List<double>();
        
        public CurrentAccount(string name) : base(name)
        {}

        public void AddDirectDebit(double dd)
        {
            directDebits.Add(dd);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, total value of direct debits: {TotalDirectDebits}";
        }

        public double TotalDirectDebits
        {
            get
            {
                double total = 0;
                foreach (double dd in directDebits)
                {
                    total += dd;
                }
                return total;
            }
        }

        public double TotalDirectDebitsUsingLinq 
        {
            get => directDebits.Sum();
        }
    }
}
