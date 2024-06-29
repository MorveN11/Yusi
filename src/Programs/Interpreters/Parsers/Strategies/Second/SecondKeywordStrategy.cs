namespace Yusi.Programs.Interpreters.Parsers.Strategies;

using Yusi.Programs.Interpreters.Statements;

public class SecondKeywordStrategy : ParseStrategy
{
    public Statement Parse(int position, List<string> tokens)
    {
        StatementStrategy? statementStrategy = null;

        if (tokens[position + 1] == "KANCHAY")
        {
            statementStrategy = new AssignmentStrategy();
        }
        else if (tokens[position + 1] == "." || Tokens.Keywords.Contains(tokens[position + 1]))
        {
            statementStrategy = new OperationStrategy();
        }

        if (statementStrategy == null)
        {
            throw new Exception("Sintax Error");
        }

        return statementStrategy.Interpret(position, tokens);
    }
}
