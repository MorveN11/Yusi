namespace Yusi.Programs.Interpreters;

public static class Tokens
{
    public static readonly ISet<string> BlockCodeKeywords = new HashSet<string>
    {
        "QUIPA",
        "CHAYPI",
        "CHAY"
    };

    public static readonly ISet<string> Keywords = new HashSet<string>
    {
        "HUAMPI", // Declaration
        "KANCHAY", // Assignment
        "LLANPAY", // Addition
        "AQHAY", // Subtraction
        "CHINKAY", // Multiplication
        "CHUTAY", // Division
        "QUISPI", // Modulus
        "CHAY", // If
        "CHAYPI", // Else
        "QUIPA", // While
        "MUYU", // Code block start
        "PUNCHAW", // Code block end
        "WANKA", // Minor than
        "WANKACHO", // Minor or equal than
        "HINA", // Major than
        "HINACHO", // Major or equal than
        "KAYCHU", // Equal
        "WAKJINA", // Not
        "MANAN", // Not equal
    };

    public static readonly ISet<char> EspecialCharacters = new HashSet<char> { '.', ':' };
}
