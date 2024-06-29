namespace Yusi.Programs.Interpreters.Statements.Entities;

public abstract class Expression
{
    protected Expression() { }

    public abstract int Operate(int firstValue, int secondValue);
}
