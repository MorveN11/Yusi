namespace Yusi.Programs.Interpreters.Statements.Entities;

public abstract class ValueStmt
{
    public object? Value { get; set; }

    protected ValueStmt() { }
}
