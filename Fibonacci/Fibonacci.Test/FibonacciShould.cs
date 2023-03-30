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
            var fibonacci = new Console.Fibonacci();
            var action = () => fibonacci.GetSequence(-1);
            
            action.Should().Throw<InvalidDataException>()
                .WithMessage("Negatives numbers are not allowed");
        }

        [Test]
        public void return_zero_when_given_number_is_zero()
        {
            var fibonacci = new Console.Fibonacci();

            var result = fibonacci.GetSequence(0);

            result.Should().Be("0");
        }

        [Test]
        public void return_string_01_when_given_number_is_one()
        {
            var fibonacci = new Console.Fibonacci();

            var result = fibonacci.GetSequence(1);

            result.Should().Be("0,1");
        }

        [Test]
        public void return_string_011_when_given_number_is_two()
        {
            var fibonacci = new Console.Fibonacci();

            var result = fibonacci.GetSequence(2);

            result.Should().Be("0,1,1");
        }
    }
}