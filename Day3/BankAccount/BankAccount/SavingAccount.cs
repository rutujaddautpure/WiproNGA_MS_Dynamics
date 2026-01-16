using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accNumber, string pin,decimal interest,string branchcode )
            : base(accNumber, pin, interest, branchcode)
        {
        }

        public decimal CalculateInterest()
        {
            return balance * interestRate / 100;
        }
    }
}
