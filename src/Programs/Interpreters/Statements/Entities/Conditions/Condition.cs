namespace Yusi.Programs.Interpreters.Statements.Entities;

public abstract class Condition
{
    protected Condition() { }

    public abstract bool Operate(int firstValue, int secondValue);
}
