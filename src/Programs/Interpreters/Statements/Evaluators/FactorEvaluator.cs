namespace Yusi.Programs.Interpreters.Statements.Evaluators;

using Yusi.Programs.Interpreters.Exceptions;
using Yusi.Programs.Interpreters.Statements.Entities;

public class FactorEvaluator : IEvaluator
{
    public Factor? Factor { get; set; }

    public FactorEvaluator() { }

    public int Evaluate(Dictionary<string, int> variables)
    {
        if (Factor is null)
        {
            throw new ArgumentNullException(nameof(Factor));
        }

        int answer = 0;

        if (Factor is NumberFactor numberFactor)
        {
            answer = numberFactor.Value ?? 0;
        }
        else if (Factor is IdentifierFactor identifierFactor)
        {
            if (!variables.ContainsKey(identifierFactor.Value?.Value ?? ""))
            {
                throw new VariableNotDeclaredException();
            }

            answer = variables[identifierFactor.Value?.Value ?? ""];
        }

        return answer;
    }
}
