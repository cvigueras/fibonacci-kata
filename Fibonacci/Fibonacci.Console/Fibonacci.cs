namespace Fibonacci.Console;

public class Fibonacci
{
    private string _succession = string.Empty;
    private const string Coma = ",";
    private ulong _actual = 1;
    private ulong _before;

    public string GetSequence(int number)
    {
        if (number < 0)
        {
            throw new InvalidDataException("Negatives numbers are not allowed");
        }

        return GetSuccession(number);
    }

    private string GetSuccession(int number)
    {
        _succession = number == 0 ? _before.ToString() : _succession + _before + Coma + _actual;
        for(var i = 1;i<number;i++)
        {
            var sum = _actual + _before;
            _succession += Coma + sum;
            _before = _actual;
            _actual = sum;
        }

        return _succession;
    }
}