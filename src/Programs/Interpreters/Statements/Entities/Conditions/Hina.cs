namespace Yusi.Programs.Interpreters.Statements.Entities;

public class Hina : Condition
{
    public Hina()
        : base() { }

    public override bool Operate(int firstValue, int secondValue)
    {
        return firstValue > secondValue;
    }
}
