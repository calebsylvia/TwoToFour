namespace SylviaCTwoToFour.Services;

public class WakeUpService : IWakeUpService
{
    public string wakeUp(string name, string time)
    {

        bool isTrue = int.TryParse(time, out int wakeTime);

        if(isTrue){
            return $"Nice to meet you {name}! You woke up at {wakeTime}!";
        }else{
            return "Please enter a number for the time you woke up.";
        }
        
    }
}
