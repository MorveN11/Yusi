namespace Yusi.Programs.Interpreters;

using Yusi.Programs.Interpreters.Exceptions;
using Yusi.Programs.Interpreters.Executors;
using Yusi.Programs.Interpreters.Parsers;
using Yusi.Programs.Interpreters.Tokenizers;

public class Interpreter
{
    private readonly LineTokenizer _lineTokenizer;
    private readonly Parser _parser;
    private readonly Executor _executor;
    private readonly Tokenizer _tokenizer;

    public Interpreter()
    {
        _lineTokenizer = new LineTokenizer();
        _tokenizer = new Tokenizer();
        _parser = new Parser();
        _executor = new Executor();
    }

    public IList<string>? Interpret(string input, IList<string>? tokens)
    {
        _lineTokenizer.Input = input;

        try
        {
            _lineTokenizer.Tokenize();
        }
        catch (Exception ex)
        {
            if (ex is MissingEndPeriodException || ex is MissingPuchawException)
            {
                if (tokens != null)
                {
                    _lineTokenizer.ListTokens?.InsertRange(0, tokens);
                }

                return _lineTokenizer.ListTokens;
            }

            throw new Exception(ex.Message);
        }

        if (tokens != null)
        {
            _lineTokenizer.ListTokens?.InsertRange(0, tokens);
        }

        _tokenizer.LineTokenizer = _lineTokenizer;
        _tokenizer.Tokenize();

        return Interpret(_tokenizer?.ListTokens ?? new List<List<string>>());
    }

    public IList<string>? Interpret(List<List<string>> tokens)
    {
        foreach (List<string> token in tokens)
        {
            _parser.ListTokens = token;
            _parser.Parse();

            _executor.Statement = _parser.Statement;
            _executor.Execute();
        }

        return null;
    }
}
