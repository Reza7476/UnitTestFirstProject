using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Squares;
public class SquareService
{
    public decimal Perimeter(decimal lenght)
    {
      
        return 4 * lenght;
    }

    public decimal Area(int lenght)
    {
     
        return (decimal)Math
            .Pow(lenght, 2); ;
    }
}
