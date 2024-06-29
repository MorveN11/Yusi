namespace Yusi.Programs.Interpreters.Statements.Entities;

public class ExpressionTerm : Term
{
    public new Tuple<Term, Expression, Term>? Value { get; set; }

    public ExpressionTerm()
        : base() { }
}
