
using Calculation.Service.Squares;
using FluentAssertions;
using Xunit;

namespace TestCalculateAreaAndPerimeterOfShapes.SquaresTest;
public class SquareUnitTest
{

    [Fact]
    public void Perimeter_Calculates_perimeter_of_square()
    {
        var lenght = 10;
        var expected = 40;
        var calculate = new SquareAppService();
        var actual = calculate.Perimeter(lenght);
        actual.Should().Be(expected);
    }
    [Fact]
    public void Area_Calculates_area_of_square()
    {
        var lenght = 20;
        var expected = 400;
        var calculate = new SquareAppService();
        var actual = calculate.Area(lenght);
        actual.Should().Be(expected);
    }
}
