namespace Yusi.Programs.Interpreters.Statements.Entities;

public class Wankacho : Condition
{
    public Wankacho()
        : base() { }

    public override bool Operate(int firstValue, int secondValue)
    {
        return firstValue <= secondValue;
    }
}
