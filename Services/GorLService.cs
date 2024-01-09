namespace SylviaCTwoToFour.Services;

public class GorLService : IGorLService
{
    public string compare(int x, int y)
    {
         if(x > y)
            {
                return $"Looks like ({x}) is greater than ({y})!\nLooks like ({y}) is less than ({x})!";
            }else if(x == y)
            {
                return $"Looks like ({x}) and ({y}) are equal!";
            }else
            {
                return $"Looks like ({y}) is greater than ({x})!\nLooks like ({x}) is less than ({y})!";
            }
    }
}
