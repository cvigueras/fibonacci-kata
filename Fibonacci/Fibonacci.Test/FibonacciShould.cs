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
                .WithMessage("Not negatives numbers are allowed");
        }

    }

    public class Fibonacci
    {
        public static void GetSequence()
        {
            throw new NotImplementedException();
        }
    }
}