namespace Yusi.Programs.Interpreters.Statements;

using Yusi.Programs.Interpreters.Statements.Entities;

public class ConditionalStmt : Statement
{
    public Conditional? Conditional { get; set; }
    public List<Statement>? Value { get; set; }

    public ConditionalStmt()
        : base() { }
}
