namespace Yusi.Programs.Interpreters.Tokenizers;

using Yusi.Programs.Interpreters.Exceptions;
using Yusi.Programs.Interpreters.Tokenizers.Strategies;

public class LineTokenizer
{
    public List<string>? ListTokens { get; private set; }
    public string? Input { private get; set; }
    public bool IsMuyu { get; set; }

    public LineTokenizer() { }

    public void Tokenize()
    {
        if (string.IsNullOrWhiteSpace(Input))
        {
            throw new Exception("No input to tokenize");
        }

        ListTokens = new List<string>();
        int pos = 0;

        while (pos < Input.Length)
        {
            char currentChar = Input[pos];
            TokenizeStrategy? strategy = null;

            if (char.IsWhiteSpace(currentChar))
            {
                strategy = new WhiteSpaceStrategy();
            }

            if (char.IsLetterOrDigit(currentChar))
            {
                strategy = new LetterDigitStrategy();
            }

            if (Tokens.EspecialCharacters.Contains(currentChar))
            {
                strategy = new EspecialCharacterStrategy();
            }

            if (strategy == null)
            {
                if (currentChar == '(')
                {
                    var openParenthesisStrategy = new OpenParenthesisStrategy();

                    Tuple<int, List<string>> ans = openParenthesisStrategy.Tokenize(pos, Input);

                    ListTokens.AddRange(ans.Item2);
                    pos = ans.Item1;

                    continue;
                }

                throw new Exception("Invalid character");
            }

            Tuple<int, string> result = strategy.Tokenize(pos, Input);
            pos = result.Item1;
            string token = result.Item2;

            if (!string.IsNullOrEmpty(token))
            {
                ListTokens.Add(token);
                if (token == "MUYU")
                {
                    IsMuyu = true;
                }
                else if (token == "PUNCHAW")
                {
                    IsMuyu = false;
                }
            }
        }

        if (ListTokens[^1] != ".")
        {
            throw new MissingEndPeriodException();
        }

        if (IsMuyu)
        {
            throw new MissingPuchawException();
        }
    }
}
