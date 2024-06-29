namespace Yusi.Programs.Interpreters.Statements.Evaluators;

using Yusi.Programs.Interpreters.Statements.Entities;

public class ExpressionTermEvaluator : IEvaluator
{
    public Tuple<Term, Expression, Term>? Term { get; set; }

    public ExpressionTermEvaluator() { }

    public int Evaluate(Dictionary<string, int> variables)
    {
        Term firstTerm = Term?.Item1 ?? throw new ArgumentNullException(nameof(Term));
        Term secondTerm = Term?.Item3 ?? throw new ArgumentNullException(nameof(Term));
        Expression expression = Term?.Item2 ?? throw new ArgumentNullException("Invalid term.");

        int firstTermValue = 0;
        int secondTermValue = 0;

        if (firstTerm is ExpressionTerm firstExpressionTerm)
        {
            firstTermValue = new ExpressionTermEvaluator
            {
                Term = firstExpressionTerm.Value
            }.Evaluate(variables);
        }
        else if (firstTerm is FactorTerm firstnumberTerm)
        {
            firstTermValue = new FactorEvaluator { Factor = firstnumberTerm.Value }.Evaluate(
                variables
            );
        }

        if (secondTerm is ExpressionTerm secondExpressionTerm)
        {
            secondTermValue = new ExpressionTermEvaluator
            {
                Term = secondExpressionTerm.Value
            }.Evaluate(variables);
        }
        else if (secondTerm is FactorTerm numberTerm)
        {
            secondTermValue = new FactorEvaluator { Factor = numberTerm.Value }.Evaluate(variables);
        }

        return expression.Operate(firstTermValue, secondTermValue);
    }
}
