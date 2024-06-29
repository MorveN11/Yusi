namespace Yusi.Programs.Interpreters.Statements.Entities;

public class Wanka : Condition
{
    public Wanka()
        : base() { }

    public override bool Operate(int firstValue, int secondValue)
    {
        return firstValue < secondValue;
    }
}
