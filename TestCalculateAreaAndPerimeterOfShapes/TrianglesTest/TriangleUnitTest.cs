using Calculation.Service.Triangles;
using Calculation.Service.Triangles.Exceptions;
using FluentAssertions;
using Xunit;

namespace TestCalculateAreaAndPerimeterOfShapes.TrianglesTest;
public class TriangleUnitTest
{
    [Fact]
    public void Area_calculates_area_of_triangle_using_three_sides()
    {
        var aSide = 8;
        var bSide = 8;
        var cSide = 8;
        var expected = 27.713;
        var calculate = new TriangleAppService();
        var actual = calculate.Area(aSide, bSide, cSide);
        actual.Should().Be(expected);
    }

    [Fact]
    public void Preimeter_calculates_primeter_of_triangle_using_three_sides()
    {
        var aSide = 8;
        var bSide = 8;
        var cSide = 8;
        var expected = 24;
        var calculate = new TriangleAppService();
        var actural = calculate.Primeter(aSide, bSide, cSide);

        actural.Should().Be(expected);
    }

    [Fact]
    public void Area_throws_A_SideGreatherThanSumOfB_SideAndC_SideException_when_firstSide_is_greather_than_SumOfSecondSideand_Third()
    {
        var firstSide = 30;
        var secondeSide = 5;
        var thirdSide = 15;
        var calcuate = new TriangleAppService();
        var actual = () => calcuate.Area(firstSide, secondeSide, thirdSide);
        actual.Should().ThrowExactly<A_SideGreatherThanSumOfB_SideAndC_SideException>();
    }
    [Fact]
    public void Area_throws_B_SideGreatherThanSumOfA_SideAndC_SideException_when_secondSide_is_GreatherThan_SumOfFirstSideAndThird()
    {
        var bSide = 50;
        var aSide = 30;
        var cdSide = 15;
        var calcuate = new TriangleAppService();
        var actual = () => calcuate.Area(aSide, bSide, cdSide);
        actual.Should().ThrowExactly<B_SideGreatherThanSumOfA_SideAndC_SideException>();
    }
    [Fact]
    public void Area_throws_C_SideGreatherThanSumOfA_SideAndB_SideException_when_thirdSide_is_greather_than_sumOfFirstSideand_Seconde()
    {
        var bSide = 50;
        var aSide = 30;
        var cSide = 150;
        var calcuate = new TriangleAppService();
        var actual = () => calcuate.Area(aSide, bSide, cSide);
        actual.Should().ThrowExactly<C_SideGreatherThanSumOfA_SideAndB_SideException>();
    }
}
