using Calculation.Service.Rectangles;
using FluentAssertions;
using Xunit;

namespace TestCalculateAreaAndPerimeterOfShapes.RectanglesTest;
public class RectangleUnitTest
{

    [Fact]
    public void Perimeter_calculates_perimatere_of_rectangle()
    {
        var length = 10;
        var width = 20;
        var expected = 60;
        var calculate = new RectangleAppService();

        var actual = calculate.Perimeter(length, width);


        actual.Should().Be(expected);
    }
    [Fact]
    public void Area_calculates_area_of_rectangle()
    {
        var length = 10;
        var width = 5;
        var expected = 50;
        var calculate = new RectangleAppService();
        var actual = calculate.Area(length, width);
        actual.Should().Be(expected);
    }

}
