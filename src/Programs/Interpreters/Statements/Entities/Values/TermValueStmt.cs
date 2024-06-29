namespace Yusi.Programs.Interpreters.Statements.Entities;

public class TermValueStmt : ValueStmt
{
    public new Term? Value { get; set; }

    public TermValueStmt()
        : base() { }
}
