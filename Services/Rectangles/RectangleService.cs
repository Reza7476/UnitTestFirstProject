using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Rectangles;
public class RectangleService
{
    public decimal Perimeter(decimal length, decimal width)
    {
        var perimeter = 2 * (length + width);
        return perimeter;

    }

    public decimal Area(decimal length, decimal width)
    {

        var area = length * width;
        return area;


    }
}
