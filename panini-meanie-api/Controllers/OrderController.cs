// OrderController.cs
//
// Api controller to allow users to place orders

using Microsoft.AspNetCore.Mvc;

namespace panini_meanie_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private ILogger _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpGet, Route("get")]
        public IEnumerable<string> Get()
        {
            return new List<string>() { "dinner" };
        }
    }
}
