using Calculation.Service.FizzBuzzGames;
using FluentAssertions;
using Xunit;

namespace TestCalculateAreaAndPerimeterOfShapes.FizzBuzzTest;
public class FizzBuzzUnitTest
{

    [Theory]
    [InlineData("Fizz", 6)]
    [InlineData("Buzz", 10)]
    [InlineData("FizzBuzz", 15)]
    [InlineData("8", 8)]
    public void FizzBuzz_returns_fizzOrBuzz(string excepted, int num)
    {
        var calculate = new FizzBuzzGameAppService();
        var actual = calculate.FizzBuzz(num);
        actual.Should().Be(excepted);
    }
}

