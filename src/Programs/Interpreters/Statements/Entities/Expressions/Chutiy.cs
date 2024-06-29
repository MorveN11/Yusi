namespace Yusi.Programs.Interpreters.Statements.Entities;

public class Chutiy : Expression
{
    public Chutiy()
        : base() { }

    public override int Operate(int firstValue, int secondValue)
    {
        return firstValue / secondValue;
    }
}
