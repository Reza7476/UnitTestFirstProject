
using Calculation.Service.Circles;
using FluentAssertions;
using Xunit;

namespace TestCalculateAreaAndPerimeterOfShapes.CirclesTest;
public class CircleUnitTest
{

    [Fact]
    public void Area_claculates_circles_area_using_raduis()
    {
        var radius = 2;
        var expected = 12.56;
        var calculate = new CircleAppServices();
        var actual = calculate.Area(radius);
        actual.Should().Be(expected);
    }


    [Fact]

    public void Primeter_calculates_circles_primeter_using_raduis()
    {
        var radius = 2;
        var expected = 12.56;
        var calculate = new CircleAppServices();
        var actual = calculate.Primeter(radius);
        actual.Should().Be(expected);
    }

}