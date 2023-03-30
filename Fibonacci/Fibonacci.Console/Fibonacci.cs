namespace Fibonacci.Console;

public class Fibonacci
{
    public string GetSequence(int number)
    {
        if (number < 0)
        {
            throw new InvalidDataException("Negatives numbers are not allowed");
        }

        if (number == 1)
        {
            return "0,1";
        }

        if (number == 2)
        {
            return "0,1,1";
        }
        return "0";
    }
}