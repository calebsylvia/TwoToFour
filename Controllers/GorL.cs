using Microsoft.AspNetCore.Mvc;
using SylviaCTwoToFour.Services;

namespace SylviaCTwoToFour.Controllers;


[ApiController]
[Route("GorL")]
    public class GorL : ControllerBase
    {
    private readonly IGorLService _gorLService;

    public GorL(IGorLService gorLService)
    {
        _gorLService = gorLService;
    }

        [HttpPost]
        [Route("GorL")]

        public string compare(int x, int y)
        {
            return _gorLService.compare(x, y);
        }

    }
