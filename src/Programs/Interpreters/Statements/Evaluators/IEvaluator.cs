namespace Yusi.Programs.Interpreters.Statements.Evaluators;

public interface IEvaluator
{
    public int Evaluate(Dictionary<string, int> variables);
}
