namespace Yusi.Programs.Interpreters.Statements.Evaluators;

using Yusi.Programs.Interpreters.Statements.Entities;

public class ConditionalEvaluator
{
    public Tuple<Factor, Condition, Factor>? Conditional { get; set; }

    public ConditionalEvaluator() { }

    public bool Evaluate(Dictionary<string, int> variables)
    {
        Factor firstTerm = Conditional?.Item1 ?? throw new ArgumentNullException(nameof(Term));
        Factor secondTerm = Conditional?.Item3 ?? throw new ArgumentNullException(nameof(Term));
        Condition condition =
            Conditional?.Item2 ?? throw new ArgumentNullException("Invalid term.");

        int firstTermValue = new FactorEvaluator { Factor = firstTerm }.Evaluate(variables);
        int secondTermValue = new FactorEvaluator { Factor = secondTerm }.Evaluate(variables);

        return condition.Operate(firstTermValue, secondTermValue);
    }
}
