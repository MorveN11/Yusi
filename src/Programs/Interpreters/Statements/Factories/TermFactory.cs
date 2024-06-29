namespace Yusi.Programs.Interpreters.Statements.Factories;

using Yusi.Programs.Interpreters.Statements.Entities;

public class TermFactory
{
    public List<string>? ListTokens { get; set; }
    private readonly FactorFactory _factorFactory;
    private readonly ExpressionFactory _expressionFactory;

    public TermFactory()
    {
        _factorFactory = new FactorFactory();
        _expressionFactory = new ExpressionFactory();
    }

    public Term GetTerm()
    {
        if (ListTokens == null || ListTokens.Count == 0)
        {
            throw new ArgumentNullException(nameof(ListTokens));
        }

        _factorFactory.Token = ListTokens[0];
        FactorTerm firstFactor = new FactorTerm { Value = _factorFactory.GetFactor() };

        if (ListTokens.Count == 1)
        {
            return firstFactor;
        }

        _factorFactory.Token = ListTokens[2];
        FactorTerm secondFactor = new FactorTerm { Value = _factorFactory.GetFactor() };

        _expressionFactory.Token = ListTokens[1];
        Expression expression = _expressionFactory.GetExpression();

        return new ExpressionTerm
        {
            Value = new Tuple<Term, Expression, Term>(firstFactor, expression, secondFactor)
        };
    }
}
