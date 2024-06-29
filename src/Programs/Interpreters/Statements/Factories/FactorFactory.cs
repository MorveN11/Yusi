namespace Yusi.Programs.Interpreters.Statements.Factories;

using Yusi.Programs.Interpreters.Statements.Entities;

public class FactorFactory
{
    public string? Token { get; set; }

    public FactorFactory() { }

    public Factor GetFactor()
    {
        if (string.IsNullOrWhiteSpace(Token))
        {
            throw new ArgumentNullException(nameof(Token));
        }

        bool isNumber = int.TryParse(Token, out int number);

        if (isNumber)
        {
            return new NumberFactor { Value = number };
        }
        else
        {
            return new IdentifierFactor { Value = new Identifier { Value = Token } };
        }
    }
}
