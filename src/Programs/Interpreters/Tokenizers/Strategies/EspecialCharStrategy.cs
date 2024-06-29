namespace Yusi.Programs.Interpreters.Tokenizers.Strategies;

using Yusi.Programs.Interpreters;

public class EspecialCharacterStrategy : TokenizeStrategy
{
    public Tuple<int, string> Tokenize(int position, string input)
    {
        char currentChar = input[position];

        if (input == null)
        {
            throw new ArgumentNullException(nameof(input));
        }

        if (!Tokens.EspecialCharacters.Contains(currentChar))
        {
            throw new Exception("Invalid character");
        }

        return new Tuple<int, string>(++position, currentChar.ToString());
    }
}
