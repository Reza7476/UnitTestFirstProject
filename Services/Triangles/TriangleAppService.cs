﻿using Calculations.Cotracts.Triangles;
using Services.Triangles.Exceptions;

namespace Services.Triangles;
public static class TriangleAppService
{
    public static double Area(double aSide,
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
        var result = (s) * (s - aSide) * (s - bSide) * (s - cSide);
        var area = Math.Sqrt(result);
        return Math.Round(area, 3); ;
    }

    public static double Primeter(double aSide,
        double bSide,
        double cSide)
    {
        return Math.Round((aSide + bSide + cSide), 2);

    }
}

