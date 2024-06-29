namespace Yusi.Programs.Interpreters.Parsers.Strategies;

using Yusi.Programs.Interpreters.Statements;

public interface ParseStrategy
{
    public Statement Parse(int position, List<string> tokens);
}
