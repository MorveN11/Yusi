namespace Yusi.Programs.Interpreters.Executors.Strategies;

using Yusi.Programs.Interpreters.Statements;
using Yusi.Programs.Interpreters.Statements.Evaluators;

public class AssignmentStrategy : ExecuteStrategy<Assignment>
{
    private readonly ValueStmtEvaluator _valueStmtEvaluator;
    public bool Result { get; set; }

    public AssignmentStrategy()
    {
        _valueStmtEvaluator = new ValueStmtEvaluator();
    }

    public void Execute(Assignment statement, Dictionary<string, int> variables)
    {
        string identifier = statement?.Identifier?.Value ?? "";

        if (!variables.ContainsKey(identifier))
        {
            Console.WriteLine("mana kanchu");
            return;
        }

        _valueStmtEvaluator.Value = statement?.Value;
        Tuple<bool, int> value = _valueStmtEvaluator.Evaluate(variables);

        if (!value.Item1)
        {
            Console.WriteLine("mana kanchu");
            return;
        }

        variables[identifier] = value.Item2;
        Console.WriteLine(value.Item2);
    }
}
