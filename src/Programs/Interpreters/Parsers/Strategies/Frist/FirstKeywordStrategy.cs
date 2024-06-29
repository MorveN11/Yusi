namespace Yusi.Programs.Interpreters.Parsers.Strategies;

using Yusi.Programs.Interpreters.Statements;

public class FirstKeywordStrategy : ParseStrategy
{
    public Statement Parse(int position, List<string> tokens)
    {
        StatementStrategy? statementStrategy = null;

        if (tokens[position] == "HUAMPI")
        {
            statementStrategy = new DeclarationStrategy();
        }
        else if (tokens[position] == "CHAY")
        {
            statementStrategy = new ConditionalStrategy();
        }
        else if (tokens[position] == "CHAYPI")
        {
            statementStrategy = new ElseConditionalStrategy();
        }
        else if (tokens[position] == "QUIPA")
        {
            statementStrategy = new LoopStrategy();
        }

        if (statementStrategy == null)
        {
            throw new Exception("Sintax Error");
        }

        return statementStrategy.Interpret(position, tokens);
    }
}
