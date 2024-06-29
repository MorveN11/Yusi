namespace Yusi.Programs.Interpreters.Exceptions;

public class VariableNotDeclaredException : Exception
{
    public VariableNotDeclaredException()
        : base("Variable Not Declared Exception") { }
}
