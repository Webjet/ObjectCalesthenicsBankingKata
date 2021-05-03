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
    }
}
