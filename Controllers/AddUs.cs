using Microsoft.AspNetCore.Mvc;
using SylviaCTwoToFour.Services;

namespace SylviaCTwoToFour.Controllers;

[ApiController]
[Route("TwoToFour")]

    public class TwoToFour : ControllerBase
    {
    private readonly IAddUsService _addUsService;

    public TwoToFour(IAddUsService addUsService)
    {
        _addUsService = addUsService;
    }

    [HttpGet]
    [Route("Add")]
        public string addMe(int x, int y)
        {
            return _addUsService.addMe(x, y);
        }

    }

    // http://localhost:5278/TwoToFour/Add?x=0&y=0
