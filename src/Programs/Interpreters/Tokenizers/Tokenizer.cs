namespace Yusi.Programs.Interpreters.Tokenizers;

public class Tokenizer
{
    public List<List<string>>? ListTokens { get; private set; }
    public LineTokenizer? LineTokenizer { get; set; }

    public Tokenizer() { }

    public void Tokenize()
    {
        ListTokens = new List<List<string>>();

        List<string> tokens = LineTokenizer?.ListTokens ?? new List<string>();

        int index = 0;

        while (index < tokens.Count)
        {
            int finalIndex = 0;

            if (!Tokens.BlockCodeKeywords.Contains(tokens[index]))
            {
                finalIndex = tokens.IndexOf(".", index);
            }
            else
            {
                finalIndex = tokens.IndexOf("PUNCHAW", index) + 1;
            }

            List<string> tokenStatement = tokens.GetRange(index, finalIndex - index + 1);
            ListTokens.Add(tokenStatement);

            index = finalIndex + 1;
        }
    }
}
