using Calculation.Service.Triangles.Exceptions;

namespace Calculation.Service.Triangles;
public class TriangleAppService : TriangleService
{
    public double Area(double aSide,
        double bSide,
        double cSide)
    {
        if (aSide > bSide + cSide)
            throw new A_SideGreatherThanSumOfB_SideAndC_SideException();
        if (bSide > aSide + cSide)
            throw new B_SideGreatherThanSumOfA_SideAndC_SideException();
        if (cSide > bSide + aSide)
            throw new C_SideGreatherThanSumOfA_SideAndB_SideException();
        var perimeter = aSide + bSide + cSide;
        var s = perimeter / 2;
        var result = s * (s - aSide) * (s - bSide) * (s - cSide);
        var area = Math.Sqrt(result);
        return Math.Round(area, 3); ;
    }

    public double Primeter(double aSide,
        double bSide,
        double cSide)
    {
        return Math.Round(aSide + bSide + cSide, 2);

    }
}

