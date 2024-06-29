namespace Yusi.Programs.Interpreters.Statements;

using Yusi.Programs.Interpreters.Statements.Entities;

public class Declaration : Statement
{
    public Identifier? Identifier { get; set; }

    public Declaration()
        : base() { }
}
