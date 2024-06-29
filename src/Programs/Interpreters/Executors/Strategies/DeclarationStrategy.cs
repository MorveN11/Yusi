namespace Yusi.Programs.Interpreters.Executors.Strategies;

using Yusi.Programs.Interpreters.Statements;

public class DeclarationStrategy : ExecuteStrategy<Declaration>
{
    public bool Result { get; set; }

    public void Execute(Declaration statement, Dictionary<string, int> variables)
    {
        if (variables.ContainsKey(statement?.Identifier?.Value ?? ""))
        {
            return;
        }

        variables[statement?.Identifier?.Value ?? ""] = 0;
        Console.WriteLine("chasca");
    }
}
