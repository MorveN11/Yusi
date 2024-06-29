namespace Yusi.Programs.Interpreters.Parsers.Strategies;

using Yusi.Programs.Interpreters.Statements;
using Yusi.Programs.Interpreters.Statements.Factories;

public class OperationStrategy : StatementStrategy
{
    public Statement Interpret(int position, List<string> tokens)
    {
        tokens.RemoveAt(tokens.Count - 1);

        ValueFactory valueFactory = new ValueFactory { ListTokens = tokens };

        return new Operation { Value = valueFactory.GetValue() };
    }
}
