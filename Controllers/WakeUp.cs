using Microsoft.AspNetCore.Mvc;
using SylviaCTwoToFour.Services;

namespace SylviaCTwoToFour.Controllers;


[ApiController]
[Route("WakeUp")]
    public class WakeUp : ControllerBase
    {
    private readonly IWakeUpService _wakeUpService;

    public WakeUp(IWakeUpService wakeUpService)
    {
        _wakeUpService = wakeUpService;
    }

        [HttpPost]
        [Route("WakeUp/What_is_your_name?{name}/What_time_did_you_wake_up?{time}")]
        public string wakeUp(string name, string time)
        {
            return _wakeUpService.wakeUp(name, time);
        }


    }
