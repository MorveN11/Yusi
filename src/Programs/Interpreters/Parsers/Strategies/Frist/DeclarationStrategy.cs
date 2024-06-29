namespace Yusi.Programs.Interpreters.Parsers.Strategies;

using Yusi.Programs.Interpreters.Statements;
using Yusi.Programs.Interpreters.Statements.Entities;

public class DeclarationStrategy : StatementStrategy
{
    public Statement Interpret(int position, List<string> tokens)
    {
        if (tokens[position] != "HUAMPI" || tokens[position + 2] != ".")
            throw new Exception("Syntax error in declaration statement");

        position++;
        string identifier = tokens[position++];

        return new Declaration { Identifier = new Identifier { Value = identifier } };
    }
}
