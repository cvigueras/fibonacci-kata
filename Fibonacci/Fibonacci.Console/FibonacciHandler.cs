namespace Fibonacci.Console;

public class FibonacciHandler
{
    public int Number { get; }
    public string Succession { get; private set; }
    public string Coma { get; }
    public ulong Actual { get; private set; }
    public ulong Before { get; private set; }

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

    public string GetSuccession(int number)
    {
        Succession = number == 0
            ? Before.ToString()
            : Succession + Before + Coma + Actual;
        for (var i = 1; i < number; i++)
        {
            var sum = Actual + Before;
            Succession += Coma + sum;
            Before = Actual;
            Actual = sum;
        }

        return Succession;
    }
}