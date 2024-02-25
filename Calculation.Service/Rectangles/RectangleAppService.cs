namespace Calculation.Service.Rectangles;
public class RectangleAppService: RectangleService
{
    public double Perimeter(double length, double width)
    {
        var perimeter = 2 * (length + width);
        return perimeter;

    }

    public double Area(double length, double width)
    {

        var area = length * width;
        return area;


    }
}
