using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankTask
{
    public class MortgageAccount : Account, IDepositMoney
    {
        public MortgageAccount(string customer, CustomerType customerType, decimal balance, decimal interestRate)
            : base(customer, customerType, balance, interestRate)
        {
        }

        public override void InterestAmount(int period)
        {
            decimal interestAmount = 0;
            int months = period;

            if (CustomerType == 0)
            {
                period -= 6;
            }
            else
            {
                if (period > 12)
                {
                    interestAmount = (InterestRate / 2) * 12;
                    period -= 12;
                }
            }

            if (period <= 0)
            {
                Console.WriteLine("No interest amount");
            }
            else
            {
                interestAmount += (period * InterestRate);
                Console.WriteLine("Interest amount of {0} for {1} months is : {2}", Customer, months, interestAmount);
            }
        }
    }
}
