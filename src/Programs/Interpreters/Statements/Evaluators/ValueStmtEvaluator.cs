namespace Yusi.Programs.Interpreters.Statements.Evaluators;

using Yusi.Programs.Interpreters.Exceptions;
using Yusi.Programs.Interpreters.Statements.Entities;

public class ValueStmtEvaluator
{
    public ValueStmt? Value { get; set; }

    public ValueStmtEvaluator() { }

    public Tuple<bool, int> Evaluate(Dictionary<string, int> variables)
    {
        if (Value is null)
        {
            throw new ArgumentNullException(nameof(Term));
        }

        int answer = 0;
        IEvaluator? evaluator = null;

        if (Value is FactorValueStmt factorTerm)
        {
            evaluator = new FactorEvaluator { Factor = factorTerm.Value };
        }
        else if (Value is TermValueStmt expressionTerm)
        {
            evaluator = new TermEvaluator { Term = expressionTerm.Value };
        }

        if (evaluator is null)
        {
            throw new ArgumentNullException(nameof(evaluator));
        }

        try
        {
            answer = evaluator.Evaluate(variables);
        }
        catch (Exception ex)
        {
            if (ex is VariableNotDeclaredException)
            {
                return new Tuple<bool, int>(false, 0);
            }

            throw new Exception(ex.Message);
        }

        return new Tuple<bool, int>(true, answer);
    }
}
