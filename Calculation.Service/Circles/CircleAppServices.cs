namespace Calculation.Service.Circles;
public class CircleAppServices: CircleService
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
