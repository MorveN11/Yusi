namespace Yusi.Programs.Interpreters.Executors.Strategies;

using Yusi.Programs.Interpreters.Statements;

public class ElseConditionalStrategy : ExecuteStrategy<ElseConditionalStmt>
{
    private readonly Executor _executor;
    public bool Result { get; set; }

    public ElseConditionalStrategy(Dictionary<string, int> variables, bool previousResult)
    {
        _executor = new Executor(variables);
        Result = previousResult;
    }

    public void Execute(ElseConditionalStmt statement, Dictionary<string, int> variables)
    {
        if (Result)
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
