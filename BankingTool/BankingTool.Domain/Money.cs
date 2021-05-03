using System;

namespace BankingTool.Domain
{
    public record Money(int Value)
    {
        internal Money Substract(Money money) =>
            new Money(this.Value - money.Value);
        
        public override string ToString() => ""+Value;

        internal Money ToNegative()
        {
            return new Money(this.Value * -1);
        }

        internal Money Add(Money money) =>
            new Money(this.Value + money.Value);
    }
}
