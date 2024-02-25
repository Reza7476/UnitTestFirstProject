using Calculation.Service.Circles;
using Calculation.Service.FizzBuzzGames;
using Calculation.Service.Rectangles;
using Calculation.Service.Squares;
using Calculation.Service.Triangles;

TriangleService _triangle = new TriangleAppService();
SquareService _square = new SquareAppService();
RectangleService _rectangle = new RectangleAppService();
CircleService _circle = new CircleAppServices();
FizzBuzzService _fizz = new FizzBuzzGameAppService();
while (true)
{
    try
    {
        int run = Run();
        switch (run)
        {
            case 0:
                {
                    Environment.Exit(0);
                    break;
                }
            case 1:
                {
                    var aSide = GetDouble("enter A side of triangle");
                    var bSide = GetDouble("enter B side of triangle");
                    var cSide = GetDouble("enter C side of triangle");
                    var area = _triangle.Area(aSide, bSide, cSide);
                    var Primeter = _triangle.Primeter(aSide, bSide, cSide);
                    Console.WriteLine(area);
                    Console.WriteLine(Primeter);
                    break;
                }

            case 2:
                {
                    var side = GetDouble("enter one side of square");
                    var area = _square.Area(side);
                    var primeter = _square.Perimeter(side);
                    Console.WriteLine(area);
                    Console.WriteLine(primeter);
                    break;
                }
            case 3:
                {
                    var aSide = GetDouble("enter A Side of recangle");
                    var bSide = GetDouble("enter B side of rectangle ");
                    var area = _rectangle.Area(aSide, bSide);
                    var primeter = _rectangle.Perimeter(aSide, bSide);
                    Console.WriteLine(area);
                    Console.WriteLine(primeter);
                    break;
                }

            case 4:
                {
                    var raduis = GetDouble("enter raduis of sircle");
                    var area = _circle.Area(raduis);
                    var primeter = _circle.Primeter(raduis);
                    Console.WriteLine(area);
                    Console.WriteLine(primeter);

                    break;
                }



            case 5:
                {
                    var num = GetInteger("enter number");
                    var fizzBuzzGame = _fizz.FizzBuzz(num);
                    Console.WriteLine(fizzBuzzGame);
                    break;
                }
            default:
                Run();
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static int Run()
{
    int run;
    Console.WriteLine("" +
        "1: calculate of triangle\n" +
        "2: calculate of Square\n" +
        "3: calculate of rectangle\n" +
        "4: calculate of circle \n" +
        "5: fizzBuzzGame\n" +
        "0 End");
    run = int.Parse(Console.ReadLine()!);
    return run;
}
static double GetDouble(string message)
{
    Console.WriteLine(message);
    var result = double.Parse(Console.ReadLine()!);
    return result;
}

static int GetInteger(string message)
{
    Console.WriteLine(message);
    var result = int.Parse(Console.ReadLine()!);
    return result;
}