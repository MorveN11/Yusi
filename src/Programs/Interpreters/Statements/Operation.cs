namespace Yusi.Programs.Interpreters.Statements;

using Yusi.Programs.Interpreters.Statements.Entities;

public class Operation : Statement
{
    public ValueStmt? Value { get; set; }

    public Operation()
        : base() { }
}
