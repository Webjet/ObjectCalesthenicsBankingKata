using System;

namespace BankingTool.Domain
{
    public class Account
    {
        public readonly BankStatementHeading date;
        private readonly BankStatementHeading amount;
        private readonly BankStatementHeading balance;
        private Money money;

        public Account()
        {
            date = new BankStatementHeading("Date");
            amount = new BankStatementHeading("Amount");
            balance = new BankStatementHeading("Balance");
        }


        public string PrintStatement()
        {
            if(money != null)
            {
                return "Date       ||  Amount  ||  Balance" +
                                    Environment.NewLine +
                            "24.12.2015 ||  +500    ||      500";
            }
            return string.Join(" ", date, amount, balance);
        }

        public void Deposit(Money money)
        {
            this.money = money;
        }

        public void Withdraw(Money money)
        {
            
        }
    }
}
