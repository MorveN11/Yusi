namespace Yusi.Programs.Interpreters.Executors.Strategies;

using Yusi.Programs.Interpreters.Statements;
using Yusi.Programs.Interpreters.Statements.Evaluators;

public class OperationStrategy : ExecuteStrategy<Operation>
{
    private readonly ValueStmtEvaluator _valueStmtEvaluator;
    public bool Result { get; set; }

    public OperationStrategy()
    {
        _valueStmtEvaluator = new ValueStmtEvaluator();
    }

    public void Execute(Operation statement, Dictionary<string, int> variables)
    {
        _valueStmtEvaluator.Value = statement?.Value;
        Tuple<bool, int> value = _valueStmtEvaluator.Evaluate(variables);

        if (!value.Item1)
        {
            Console.WriteLine("mana kanchu");
            return;
        }

        Console.WriteLine(value.Item2);
    }
}
