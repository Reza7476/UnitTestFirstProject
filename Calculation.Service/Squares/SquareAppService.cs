namespace Calculation.Service.Squares;
public class SquareAppService:SquareService
{
    public double Perimeter(double lenght)
    {

        return 4 * lenght;
    }

    public double Area(double lenght)
    {

        return (double)Math
            .Pow(lenght, 2); ;
    }

   
}
