using Fibonacci.Console;
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
            var action = Console.Fibonacci.GetSequence;
            action.Should().Throw<InvalidDataException>()
                .WithMessage("Negatives numbers are not allowed");
        }
    }
}