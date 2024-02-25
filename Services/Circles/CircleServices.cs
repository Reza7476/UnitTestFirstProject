using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Circles;
public  class CircleServices
{

    public double Area(double radius)
    {
        var pi = 3.14;
        var res = Math.Pow(radius, 2);

        return pi * res;
    }

    public double Primeter(double radius)
    {
        var pi = 3.14;
        var res = 2 * pi * radius;
        return res;

    }
}
