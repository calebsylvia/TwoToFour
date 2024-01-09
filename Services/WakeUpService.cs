namespace SylviaCTwoToFour.Services;

public class WakeUpService : IWakeUpService
{
    public string wakeUp(string name, string time)
    {
        return $"Nice to meet you {name}! You woke up at {time}!";
    }
}
