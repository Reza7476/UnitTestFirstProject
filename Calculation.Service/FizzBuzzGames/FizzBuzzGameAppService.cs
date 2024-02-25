namespace Calculation.Service.FizzBuzzGames;
public class FizzBuzzGameAppService:FizzBuzzService
{
    public string FizzBuzz(int num)
    {
        if (num % 3 == 0 && num % 5 == 0)
        {
            return "FizzBuzz";
        }
        else if (num % 3 == 0)
        {
            return "Fizz";
        }
        else if (num % 5 == 0)
        {
            return "Buzz";
        }
        else
        {
            return num.ToString();
        }
    }


}
