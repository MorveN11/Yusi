namespace Yusi.Programs.Interpreters.Tokenizers.Strategies;

public class WhiteSpaceStrategy : TokenizeStrategy
{
    public Tuple<int, string> Tokenize(int position, string input)
    {
        if (input == null)
        {
            throw new ArgumentNullException(nameof(input));
        }

        while (position < input.Length && char.IsWhiteSpace(input[position]))
        {
            position++;
        }

        return new Tuple<int, string>(position, "");
    }
}
