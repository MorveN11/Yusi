namespace Yusi.Programs.Interpreters.Statements.Entities;

public class NumberFactor : Factor
{
    public new int? Value { get; set; }

    public NumberFactor()
        : base() { }
}
