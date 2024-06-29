namespace Yusi.Programs.Interpreters.Parsers.Strategies;

using Yusi.Programs.Interpreters.Statements;
using Yusi.Programs.Interpreters.Statements.Entities;
using Yusi.Programs.Interpreters.Statements.Factories;

public class LoopStrategy : StatementStrategy
{
    private readonly Parser _parser;
    private readonly ConditionalFactory _conditionalFactory;

    public LoopStrategy()
    {
        _parser = new Parser();
        _conditionalFactory = new ConditionalFactory();
    }

    public Statement Interpret(int position, List<string> tokens)
    {
        if (tokens[position] != "QUIPA")
            throw new Exception("Syntax error in loo statement");

        position++;

        List<string> conditionalTokens = new List<string>
        {
            tokens[position++],
            tokens[position++],
            tokens[position++]
        };

        position += 2;

        tokens.RemoveRange(0, position);
        tokens.RemoveRange(tokens.Count - 3, 2);

        List<List<string>> tokenStatements = new List<List<string>>();

        int index = 0;
        while (index < tokens.Count)
        {
            List<string> statement = new List<string>();

            while (index < tokens.Count && tokens[index] != ".")
            {
                statement.Add(tokens[index++]);
            }

            statement.Add(".");
            tokenStatements.Add(statement);
            index++;
        }

        List<Statement> statements = new List<Statement>();

        foreach (List<string> tokenStatement in tokenStatements)
        {
            _parser.ListTokens = tokenStatement;
            _parser.Parse();
            statements.Add(_parser.Statement!);
        }

        _conditionalFactory.ListTokens = conditionalTokens;
        Conditional conditional = _conditionalFactory.GetConditional();

        return new LoopStmt { Conditional = conditional, Value = statements };
    }
}
