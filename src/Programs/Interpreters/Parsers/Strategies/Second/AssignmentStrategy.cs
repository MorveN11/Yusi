namespace Yusi.Programs.Interpreters.Parsers.Strategies;

using Yusi.Programs.Interpreters.Statements;
using Yusi.Programs.Interpreters.Statements.Entities;
using Yusi.Programs.Interpreters.Statements.Factories;

public class AssignmentStrategy : StatementStrategy
{
    public Statement Interpret(int position, List<string> tokens)
    {
        Identifier identifier = new Identifier { Value = tokens[position] };

        if (tokens[position + 1] != "KANCHAY")
            throw new Exception("Syntax error in assignment statement");

        position += 2;

        tokens.RemoveAt(tokens.Count - 1);
        tokens = tokens.Skip(position).ToList();

        ValueFactory valueFactory = new ValueFactory { ListTokens = tokens };

        return new Assignment { Identifier = identifier, Value = valueFactory.GetValue() };
    }
}
