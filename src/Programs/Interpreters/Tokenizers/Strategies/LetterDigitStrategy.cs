namespace Yusi.Programs.Interpreters.Tokenizers.Strategies;

using System.Text;

public class LetterDigitStrategy : TokenizeStrategy
{
    public Tuple<int, string> Tokenize(int position, string input)
    {
        if (input == null)
        {
            throw new ArgumentNullException(nameof(input));
        }

        var sb = new StringBuilder();

        while (position < input.Length && char.IsLetterOrDigit(input[position]))
        {
            sb.Append(input[position]);
            position++;
        }

        return new Tuple<int, string>(position, sb.ToString());
    }
}
