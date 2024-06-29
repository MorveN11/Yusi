namespace Yusi.Programs.Interpreters.Statements.Entities;

public class Manan : Condition
{
    public Manan()
        : base() { }

    public override bool Operate(int firstValue, int secondValue)
    {
        return firstValue != secondValue;
    }
}
