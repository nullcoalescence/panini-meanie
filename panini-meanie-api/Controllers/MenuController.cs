// MenuController.cs
//
// Api controller for the menu portion of the app

using Microsoft.AspNetCore.Mvc;

namespace panini_meanie_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly ILogger<MenuController> _logger;

        public MenuController(ILogger<MenuController> logger)
        {
            _logger = logger;
        }

        [HttpGet, Route("get")]
        public IEnumerable<string> Get()
        {
            return new List<string>() { "supper" };
        }
    }
}
