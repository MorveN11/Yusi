namespace Yusi.Programs.Interpreters.Statements;

using Yusi.Programs.Interpreters.Statements.Entities;

public class Assignment : Statement
{
    public Identifier? Identifier { get; set; }
    public ValueStmt? Value { get; set; }

    public Assignment()
        : base() { }
}
