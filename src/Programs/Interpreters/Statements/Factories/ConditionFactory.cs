namespace Yusi.Programs.Interpreters.Statements.Factories;

using Yusi.Programs.Interpreters.Statements.Entities;

public class ConditionFactory
{
    public string? Token { get; set; }

    public ConditionFactory() { }

    public Condition GetCondition()
    {
        if (string.IsNullOrWhiteSpace(Token))
        {
            throw new ArgumentNullException(nameof(Token));
        }

        return Token switch
        {
            "WANKA" => new Wanka(),
            "HINA" => new Hina(),
            "HINACHO" => new Hinacho(),
            "WANKACHO" => new Wankacho(),
            "KAYCHU" => new Kaychu(),
            "MANAN" => new Manan(),
            _ => throw new ArgumentException("Invalid token", nameof(Token)),
        };
    }
}
