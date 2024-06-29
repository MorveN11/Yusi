namespace Yusi.Programs.Interpreters.Statements.Entities;

public class IdentifierFactor : Factor
{
    public new Identifier? Value { get; set; }

    public IdentifierFactor()
        : base() { }
}
