namespace Fibonacci.Console;

public class Fibonacci
{
    public string GetSequence(FibonacciHandler fibonacciHandler)
    {
        if (fibonacciHandler.Number < 0)
        {
            throw new InvalidDataException("Negatives numbers are not allowed");
        }

        return GetSuccession(fibonacciHandler.Number, fibonacciHandler);
    }

    private string GetSuccession(int number, FibonacciHandler fibonacciHandler)
    {
        fibonacciHandler.Succession = number == 0
            ? fibonacciHandler.Before.ToString()
            : fibonacciHandler.Succession + fibonacciHandler.Before + fibonacciHandler.Coma + fibonacciHandler.Actual;
        for (var i = 1; i < number; i++)
        {
            var sum = fibonacciHandler.Actual + fibonacciHandler.Before;
            fibonacciHandler.Succession += fibonacciHandler.Coma + sum;
            fibonacciHandler.Before = fibonacciHandler.Actual;
            fibonacciHandler.Actual = sum;
        }

        return fibonacciHandler.Succession;
    }
}