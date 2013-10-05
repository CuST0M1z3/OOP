using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankTask
{
    public class LoanAccount : Account, IDepositMoney
    {
        public LoanAccount(string customer, CustomerType customerType, decimal balance, decimal interestRate)
            : base(customer, customerType, balance, interestRate)
        {
        }

        public override void InterestAmount(int period)
        {
            int months = period;
            if (CustomerType == 0)
            {
                period -= 3;               
            }
            else
            {
                period -= 2;
            }

            if (period <= 0)
            {
                Console.WriteLine("No interest amount");
            }
            else
            {
                Console.WriteLine("Interest amount of {0} for {1} months is : {2}", Customer, months, period * InterestRate);
            }
        }
    }
}
