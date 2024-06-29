namespace Yusi.Programs.Interpreters.Statements;

using Yusi.Programs.Interpreters.Statements.Entities;

public class LoopStmt : Statement
{
    public Conditional? Conditional { get; set; }
    public List<Statement>? Value { get; set; }

    public LoopStmt()
        : base() { }
}
