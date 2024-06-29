namespace Yusi.Programs.Interpreters.Executors;

using Yusi.Programs.Interpreters.Executors.Strategies;
using Yusi.Programs.Interpreters.Statements;

public class Executor
{
    private readonly Dictionary<string, int> _variables;
    public Statement? Statement { private get; set; }
    public bool PreviousResult { private get; set; }

    public Executor()
    {
        _variables = new Dictionary<string, int>();
    }

    public Executor(Dictionary<string, int> variables, bool previousResult = false)
    {
        _variables = variables;
        PreviousResult = previousResult;
    }

    public void Execute()
    {
        if (Statement == null)
        {
            throw new Exception("No statement to execute");
        }

        if (Statement is Declaration declaration)
        {
            ExecuteStrategy<Declaration> strategy = new DeclarationStrategy();
            strategy.Execute(declaration, _variables);
        }
        else if (Statement is Assignment assignment)
        {
            ExecuteStrategy<Assignment> strategy = new AssignmentStrategy();
            strategy.Execute(assignment, _variables);
        }
        else if (Statement is Operation operation)
        {
            ExecuteStrategy<Operation> strategy = new OperationStrategy();
            strategy.Execute(operation, _variables);
        }
        else if (Statement is ConditionalStmt conditional)
        {
            ExecuteStrategy<ConditionalStmt> strategy = new ConditionalStrategy(_variables);
            strategy.Execute(conditional, _variables);
            PreviousResult = strategy.Result;
            return;
        }
        else if (Statement is ElseConditionalStmt elseConditional)
        {
            ExecuteStrategy<ElseConditionalStmt> strategy = new ElseConditionalStrategy(
                _variables,
                PreviousResult
            );
            strategy.Execute(elseConditional, _variables);
        }
        else if (Statement is LoopStmt loop)
        {
            ExecuteStrategy<LoopStmt> strategy = new LoopStrategy(_variables);
            strategy.Execute(loop, _variables);
        }
        else
        {
            throw new Exception("Unknown statement type");
        }

        PreviousResult = true;
    }
}
