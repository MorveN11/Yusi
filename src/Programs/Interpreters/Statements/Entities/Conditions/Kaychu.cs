namespace Yusi.Programs.Interpreters.Statements.Entities;

public class Kaychu : Condition
{
    public Kaychu()
        : base() { }

    public override bool Operate(int firstValue, int secondValue)
    {
        return firstValue == secondValue;
    }
}
