using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2. A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
//Customers could be individuals or companies.
//All accounts have customer, balance and interest rate (monthly based). 
//Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months).
//In the common case its is calculated as follows: number_of_months * interest_rate.
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces. 
//You should identify the classes, interfaces, base classes and abstract actions and 
//implement the calculation of the interest functionality through overridden methods

namespace _2.BankTask
{
    public class BankTest
    {
        public static void Main()
        {
            DepositAccount deposit = new DepositAccount("Dani", CustomerType.Individual, 1300, 4);
            LoanAccount loan = new LoanAccount("Telerik", CustomerType.Company, 10000, 5);
            MortgageAccount mortgage = new MortgageAccount("Mtel", CustomerType.Company, 3000, 4);

            Console.WriteLine("Current deposit balance is: " + deposit.Balance);
            deposit.DepositMoney(500);
            Console.WriteLine("Current deposit balance is: " + deposit.Balance);

            Console.WriteLine("Current loan balance is: " + loan.Balance);
            loan.DepositMoney(200);
            Console.WriteLine("Current loan balance is: " + loan.Balance);

            deposit.InterestAmount(15);
            loan.InterestAmount(15);
            mortgage.InterestAmount(15);

        }
    }
}
