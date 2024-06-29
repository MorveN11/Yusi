namespace Yusi.Programs.Interpreters.Statements.Entities;

public class Quispi : Expression
{
    public Quispi()
        : base() { }

    public override int Operate(int firstValue, int secondValue)
    {
        return firstValue % secondValue;
    }
}
