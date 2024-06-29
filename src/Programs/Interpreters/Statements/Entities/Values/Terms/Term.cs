namespace Yusi.Programs.Interpreters.Statements.Entities;

public abstract class Term
{
    public object? Value { get; set; }

    protected Term() { }
}
