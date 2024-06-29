namespace Yusi.Programs.Interpreters.Tokenizers.Strategies;

public interface TokenizeStrategy
{
    public Tuple<int, string> Tokenize(int position, string input);
}
