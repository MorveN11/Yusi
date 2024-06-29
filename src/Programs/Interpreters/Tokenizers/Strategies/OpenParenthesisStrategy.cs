namespace Yusi.Programs.Interpreters.Tokenizers.Strategies;

public class OpenParenthesisStrategy
{
    public Tuple<int, List<string>> Tokenize(int position, string input)
    {
        if (input == null)
        {
            throw new ArgumentNullException(nameof(input));
        }

        int initPosition = position;
        position = input.IndexOf(')', initPosition);

        string token = input.Substring(initPosition + 1, position - initPosition - 1).Trim();

        List<string> tokens = token.Split(' ').ToList();

        if (!Tokens.Keywords.Contains(tokens[1]))
        {
            throw new Exception("Invalid keyword");
        }

        return new Tuple<int, List<string>>(++position, tokens);
    }
}
