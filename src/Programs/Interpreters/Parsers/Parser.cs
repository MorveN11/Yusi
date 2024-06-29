namespace Yusi.Programs.Interpreters.Parsers;

using Yusi.Programs.Interpreters;
using Yusi.Programs.Interpreters.Parsers.Strategies;
using Yusi.Programs.Interpreters.Statements;

public class Parser
{
    public Statement? Statement { get; private set; }
    public List<string>? ListTokens { private get; set; }

    public Parser() { }

    public void Parse()
    {
        if (ListTokens == null)
        {
            throw new Exception("No tokens to parse");
        }

        Statement = ParseStatement(ListTokens);
    }

    private Statement ParseStatement(List<string> tokens)
    {
        int pos = 0;
        ParseStrategy? parseStrategy = null;

        if (Tokens.Keywords.Contains(tokens[pos]))
        {
            parseStrategy = new FirstKeywordStrategy();
        }
        else if (tokens[pos + 1] == "." || Tokens.Keywords.Contains(tokens[pos + 1]))
        {
            parseStrategy = new SecondKeywordStrategy();
        }

        if (parseStrategy is null)
        {
            throw new Exception("Sintax error");
        }

        return parseStrategy.Parse(pos, tokens);
    }
}
