namespace Fibonacci.Console;

public class Fibonacci
{
    public string GetSequence(FibonacciHandler fibonacciHandler)
    {
        if (fibonacciHandler.Number < 0)
        {
            throw new InvalidDataException("Negatives numbers are not allowed");
        }

        return fibonacciHandler.GetSuccession(fibonacciHandler.Number);
    }
}