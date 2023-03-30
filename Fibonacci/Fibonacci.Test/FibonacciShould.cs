using Fibonacci.Console;
using FluentAssertions;

namespace Fibonacci.Test
{
    public class FibonacciShould
    {
        private Console.Fibonacci _fibonacci;

        [SetUp]
        public void Setup()
        {
            _fibonacci = new Console.Fibonacci();
        }

        [Test]
        public void return_exception_when_given_number_is_negative()
        {
            var action = () => _fibonacci.GetSequence(FibonacciHandler.Create(-1));
            
            action.Should().Throw<InvalidDataException>()
                .WithMessage("Negatives numbers are not allowed");
        }

        [Test]
        public void return_zero_when_given_number_is_zero()
        {
            var result = _fibonacci.GetSequence(FibonacciHandler.Create(0));

            result.Should().Be("0");
        }

        [TestCase(1, "0,1")]
        [TestCase(2, "0,1,1")]
        [TestCase(3, "0,1,1,2")]
        [TestCase(4, "0,1,1,2,3")]
        [TestCase(5, "0,1,1,2,3,5")]
        [TestCase(6, "0,1,1,2,3,5,8")]
        [TestCase(7, "0,1,1,2,3,5,8,13")]
        [TestCase(8, "0,1,1,2,3,5,8,13,21")]
        [TestCase(9, "0,1,1,2,3,5,8,13,21,34")]
        public void return_sequence_when_given_number_is_greater_than_zero(int input, string expectedResult)
        {
            var result = _fibonacci.GetSequence(FibonacciHandler.Create(input));

            result.Should().Be(expectedResult);
        }
    }
}