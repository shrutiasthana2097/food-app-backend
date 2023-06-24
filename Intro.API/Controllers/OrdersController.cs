using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Intro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [Route("getAllOrders")]
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            return Ok("All Orders");
        }
    }
}
