namespace Yusi.Programs.Interpreters.Statements.Entities;

public class FactorTerm : Term
{
    public new Factor? Value { get; set; }

    public FactorTerm()
        : base() { }
}
