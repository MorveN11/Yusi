namespace Yusi.Programs.Interpreters.Statements.Factories;

using Yusi.Programs.Interpreters.Statements.Entities;

public class ValueFactory
{
    public List<string>? ListTokens { get; set; }
    private readonly FactorFactory _factorFactory;
    private readonly TermFactory _termFactory;

    public ValueFactory()
    {
        _factorFactory = new FactorFactory();
        _termFactory = new TermFactory();
    }

    public ValueStmt GetValue()
    {
        if (ListTokens == null || ListTokens.Count == 0)
        {
            throw new ArgumentNullException(nameof(ListTokens));
        }

        if (ListTokens.Count == 1)
        {
            _factorFactory.Token = ListTokens[0];
            return new FactorValueStmt { Value = _factorFactory.GetFactor() };
        }

        _termFactory.ListTokens = ListTokens;
        return new TermValueStmt { Value = _termFactory.GetTerm() };
    }
}
