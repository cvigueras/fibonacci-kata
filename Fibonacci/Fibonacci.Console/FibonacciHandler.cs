namespace Fibonacci.Console;

public class FibonacciHandler
{
    public int Number { get; }
    public string Succession { get; set; }
    public string Coma { get; }
    public ulong Actual { get; set; }
    public ulong Before { get; set; }

    private FibonacciHandler(int number)
    {
        Number = number;
        Coma = ",";
        Succession = string.Empty;
        Actual = 1;
        Before = 0;
    }

    public static FibonacciHandler Create(int number)
    {
        return new FibonacciHandler(number);
    }

}