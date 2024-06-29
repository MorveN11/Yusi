namespace Yusi.Programs.Interpreters.Statements;

public class ElseConditionalStmt : Statement
{
    public List<Statement>? Value { get; set; }

    public ElseConditionalStmt()
        : base() { }
}
