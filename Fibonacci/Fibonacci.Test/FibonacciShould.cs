using FluentAssertions;

namespace Fibonacci.Test
{
    public class FibonacciShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void return_exception_when_number_is_negative()
        {
            Action action = () => Fibonacci.GetSequence();
            action.Should().Throw<InvalidDataException>()
                .WithMessage("Negatives numbers are not allowed");
        }

    }

    public class Fibonacci
    {
        public static void GetSequence()
        {
            throw new InvalidDataException("Negatives numbers are not allowed");
        }
    }
}