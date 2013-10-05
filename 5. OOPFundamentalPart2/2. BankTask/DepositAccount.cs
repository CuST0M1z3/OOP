using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankTask
{
    public class DepositAccount : Account, IDepositMoney ,IWithDrawMoney
    {
        public DepositAccount(string customer, CustomerType customerType, decimal balance, decimal interestRate)
            : base(customer, customerType, balance, interestRate)
        {
        }

        public void WithdrawMoney(decimal money)
        {
            this.Balance -= money;
        }

        public override void InterestAmount(int period)
        {
            if (Balance <= 1000)
            {
                Console.WriteLine("No interest");
            }
            else
            {
                Console.WriteLine("Interest amount of {0} for {1} months is : {2}", Customer ,period, period * InterestRate);
            }
        }        
    }
}
