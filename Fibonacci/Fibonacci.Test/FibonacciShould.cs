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
        public void return_exception_when_given_number_is_negative()
        {
            var action = () => Console.Fibonacci.GetSequence(-1);
            
            action.Should().Throw<InvalidDataException>()
                .WithMessage("Negatives numbers are not allowed");
        }

        [Test]
        public void return_zero_when_given_number_is_zero()
        {
            var result = Console.Fibonacci.GetSequence(0);
            result.Should().Be("0");
        }
    }
}