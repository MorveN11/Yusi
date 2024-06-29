namespace Yusi.Programs;

using Yusi.Programs.Interpreters;

public class Program
{
    private readonly Interpreter _interpreter;

    public Program()
    {
        _interpreter = new Interpreter();
    }

    public void Run()
    {
        IList<string>? tokens = null;

        while (true)
        {
            Console.Write(tokens is null ? "YuSi>> " : ">> ");

            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("LLUQSIY...");
                return;
            }

            tokens = _interpreter.Interpret(input, tokens);
        }
    }
}
