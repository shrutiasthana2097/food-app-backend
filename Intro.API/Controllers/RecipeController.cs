using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Intro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [Route("GetRecipes")]
        [HttpGet]
        public IActionResult GetRecipes()
        {
            return Ok("recipes");
        }
    }
}
