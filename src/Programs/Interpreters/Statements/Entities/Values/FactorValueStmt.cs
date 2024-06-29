namespace Yusi.Programs.Interpreters.Statements.Entities;

public class FactorValueStmt : ValueStmt
{
    public new Factor? Value { get; set; }

    public FactorValueStmt()
        : base() { }
}
