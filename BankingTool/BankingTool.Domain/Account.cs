using System;

namespace BankingTool.Domain
{
    public class Account
    {
        public readonly BankStatementHeading date;
        private readonly BankStatementHeading amount;
        private readonly BankStatementHeading balance;

        public Account()
        {
            date = new BankStatementHeading("Date");
            amount = new BankStatementHeading("Amount");
            balance = new BankStatementHeading("Balance");
        }


        public string PrintStatement()
        {
            return string.Join(" ", date, amount, balance);
        }

        public void Deposit(Money money)
        { 
        
        }
    }
}
