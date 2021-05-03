using System;

namespace BankingTool.Domain
{
    public record Money(int Value)
    {
        internal Money Substract(Money money)
        {
            return new Money(this.Value - money.Value);
        }
    }
}
