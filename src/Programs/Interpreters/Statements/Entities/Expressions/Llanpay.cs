namespace Yusi.Programs.Interpreters.Statements.Entities;

public class Llanpay : Expression
{
    public Llanpay()
        : base() { }

    public override int Operate(int firstValue, int secondValue)
    {
        return firstValue + secondValue;
    }
}
