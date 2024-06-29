namespace Yusi.Programs.Interpreters.Statements.Entities;

public class Hinacho : Condition
{
    public Hinacho()
        : base() { }

    public override bool Operate(int firstValue, int secondValue)
    {
        return firstValue >= secondValue;
    }
}
