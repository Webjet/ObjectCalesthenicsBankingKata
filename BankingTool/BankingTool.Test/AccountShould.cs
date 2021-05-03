using BankingTool.Domain;
using System;
using Xunit;

namespace BankingTool.Test
{
    public class AccountShould
    {
        [Fact]
        public void Be()
        {
            var sut = new Account();
            Assert.NotNull(sut);
        }
        [Fact]
        public void PrintHeading()
        {
            var exptected = "Date Amount Balance";
            var sut = new Account();
            var result = sut.PrintStatement();

            Assert.Equal(exptected, result);
        }

        [Fact]
        public void Display_deposit()
        {            
            var expected =  "Date       ||  Amount  ||  Balance" + 
                                    Environment.NewLine + 
                            "24.12.2015 ||  +500    ||      500";
            Money money = new(500);

            Account sut = new();

            sut.Deposit(money);

            var result = sut.PrintStatement();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Make_withdraw()
        {
            var balance = new Money(500);
            var expected =  "Date       ||  Amount  ||  Balance" +
                                    Environment.NewLine +
                            "23.8.2016  ||  -100    ||      400";

            Money money = new(100);

            Account sut = new(balance);
            sut.Withdraw(money);

            var result = sut.PrintStatement();

            Assert.Equal(expected, result);
        }
    }
}
