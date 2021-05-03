namespace BankingTool.Domain
{
    public record BankStatementHeading(string Content)
    {
        public override string ToString() => Content;
    }
}
