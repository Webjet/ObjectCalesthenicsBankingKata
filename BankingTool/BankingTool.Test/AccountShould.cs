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
    }
}
