using System;
using System.Collections.Generic;
using System.Linq;

namespace BankingTool.Domain
{
    public class Account
    {
        public readonly BankStatementHeading dateHeader;
        private readonly BankStatementHeading amountHeader;
        private readonly BankStatementHeading balanceHeader;
        private Money balance = new Money(0);
        private List<Money> transactionList = new List<Money>();

        public Account()
        {
            dateHeader = new BankStatementHeading("Date");
            amountHeader = new BankStatementHeading("Amount");
            balanceHeader = new BankStatementHeading("Balance");
        }

        public Account(Money money): this()
        {
            this.balance = money;
        }


        public string PrintStatement()
        {
            if(transactionList.Any())
            {
                return "Date       ||  Amount  ||  Balance" +
                                    Environment.NewLine +
                            $"24.12.2015 ||  {GetStatement()}    ||      {balance}";
            }
            return string.Join(" ", dateHeader, amountHeader, balanceHeader);
        }

        private string GetStatement()
        {
            var statement = transactionList[0].ToString();
            if (transactionList[0].Value > 0)
            {
                statement = "+" + statement;
            }
            return statement;
        }

        public void Deposit(Money money)
        {
            transactionList.Add(money);
            this.balance = balance.Add(money);
        }

        public void Withdraw(Money money)
        {
            var withdraw = money.ToNegative();
            transactionList.Add(withdraw);
            this.balance = this.balance.Add(withdraw);
        }
    }
}
