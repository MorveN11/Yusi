namespace Yusi.Programs.Interpreters.Statements;

public interface StatementStrategy
{
    public Statement Interpret(int position, List<string> tokens);
}
