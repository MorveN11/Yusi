namespace Yusi.Programs.Interpreters.Statements.Entities;

public class Aqhay : Expression
{
    public Aqhay()
        : base() { }

    public override int Operate(int firstValue, int secondValue)
    {
        return firstValue - secondValue;
    }
}
