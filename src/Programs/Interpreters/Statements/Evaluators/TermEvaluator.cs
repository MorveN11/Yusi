namespace Yusi.Programs.Interpreters.Statements.Evaluators;

using Yusi.Programs.Interpreters.Statements.Entities;

public class TermEvaluator : IEvaluator
{
    public Term? Term { get; set; }

    public TermEvaluator() { }

    public int Evaluate(Dictionary<string, int> variables)
    {
        if (Term is null)
        {
            throw new ArgumentNullException(nameof(Term));
        }

        IEvaluator? evaluator = null;

        if (Term is FactorTerm factorTerm)
        {
            evaluator = new FactorEvaluator { Factor = factorTerm.Value };
        }
        else if (Term is ExpressionTerm expressionTerm)
        {
            evaluator = new ExpressionTermEvaluator { Term = expressionTerm.Value };
        }

        if (evaluator is null)
        {
            throw new ArgumentNullException(nameof(evaluator));
        }

        return evaluator.Evaluate(variables);
    }
}
