namespace Yusi.Programs.Interpreters.Statements.Factories;

using Yusi.Programs.Interpreters.Statements.Entities;

public class ConditionalFactory
{
    public List<string>? ListTokens { get; set; }
    private readonly FactorFactory _factorFactory;
    private readonly ConditionFactory _conditionFactory;

    public ConditionalFactory()
    {
        _factorFactory = new FactorFactory();
        _conditionFactory = new ConditionFactory();
    }

    public Conditional GetConditional()
    {
        if (ListTokens == null || ListTokens.Count == 0)
        {
            throw new ArgumentNullException(nameof(ListTokens));
        }

        _factorFactory.Token = ListTokens[0];
        Factor firstFactor = _factorFactory.GetFactor();

        _factorFactory.Token = ListTokens[2];
        Factor secondFactor = _factorFactory.GetFactor();

        _conditionFactory.Token = ListTokens[1];
        Condition condition = _conditionFactory.GetCondition();

        return new Conditional
        {
            Value = new Tuple<Factor, Condition, Factor>(firstFactor, condition, secondFactor)
        };
    }
}
