namespace Yusi.Programs.Interpreters.Statements.Factories;

using Yusi.Programs.Interpreters.Statements.Entities;

public class ExpressionFactory
{
    public string? Token { get; set; }

    public ExpressionFactory() { }

    public Expression GetExpression()
    {
        if (string.IsNullOrWhiteSpace(Token))
        {
            throw new ArgumentNullException(nameof(Token));
        }

        return Token switch
        {
            "LLANPAY" => new Llanpay(),
            "AQHAY" => new Aqhay(),
            "CHINKAY" => new Chinkay(),
            "QUISPI" => new Quispi(),
            _ => throw new ArgumentException("Invalid token", nameof(Token)),
        };
    }
}
