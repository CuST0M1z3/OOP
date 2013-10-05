using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankTask
{
    public abstract class Account : IDepositMoney
    {
        private string customer;
        private CustomerType customerType;
        private decimal balance;
        private decimal interestRate;

        public string Customer
        {
            get { return this.customer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid customer!");
                this.customer = value;
            }
        }

        public CustomerType CustomerType
        {
            get { return this.customerType; }
            set { this.customerType = value; } 
        }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid balance!");
                this.balance = value;
            }         
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid interest rate!");
                this.interestRate = value;
            }         
        }

        public Account(string customer, CustomerType customerType, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.CustomerType = customerType;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public abstract void InterestAmount(int period);


        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }
    }
}
