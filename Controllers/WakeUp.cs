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

        [HttpGet]
        [Route("WakeUp/{name}/{time}")]
        public string wakeUp(string name, int time)
        {
            return _wakeUpService.wakeUp(name, time);
        }


    }

//http://localhost:5278/WakeUp/WakeUp/Caleb/9%3A00PM