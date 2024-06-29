namespace Yusi.Programs.Interpreters.Statements.Entities;

public class Chinkay : Expression
{
    public Chinkay()
        : base() { }

    public override int Operate(int firstValue, int secondValue)
    {
        return firstValue * secondValue;
    }
}
