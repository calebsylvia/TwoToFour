namespace SylviaCTwoToFour.Services;

public class AddUsService : IAddUsService
{
    public string addMe(int x, int y)
    {
        return $"The sum of {x} and {y} is {x + y}!";
    }
}

