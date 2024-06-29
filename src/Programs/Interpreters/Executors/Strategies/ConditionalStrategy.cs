namespace Yusi.Programs.Interpreters.Executors.Strategies;

using Yusi.Programs.Interpreters.Statements;
using Yusi.Programs.Interpreters.Statements.Entities;
using Yusi.Programs.Interpreters.Statements.Evaluators;

public class ConditionalStrategy : ExecuteStrategy<ConditionalStmt>
{
    private readonly ConditionalEvaluator _conditionalEvaluator;
    private readonly Executor _executor;
    public bool Result { get; set; }

    public ConditionalStrategy(Dictionary<string, int> variables)
    {
        _conditionalEvaluator = new ConditionalEvaluator();
        _executor = new Executor(variables);
    }

    public void Execute(ConditionalStmt statement, Dictionary<string, int> variables)
    {
        Conditional conditional =
            statement?.Conditional
            ?? throw new ArgumentNullException(nameof(statement.Conditional));

        _conditionalEvaluator.Conditional = conditional.Value;
        Result = _conditionalEvaluator.Evaluate(variables);

        if (!Result)
        {
            return;
        }

        foreach (
            Statement stmt in statement?.Value
                ?? throw new ArgumentNullException(nameof(statement.Value))
        )
        {
            _executor.Statement = stmt;
            _executor.Execute();
        }
    }
}
