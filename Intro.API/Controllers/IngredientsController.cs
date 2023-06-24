using Intro.API.Model;
using Intro.API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Intro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientsService _service;
        public IngredientsController(IIngredientsService service)
        {
            _service = service;
        }
        [Route("getAllingredients")]
        [HttpGet]
        public List<Ingredient> GetAllIngredients()
        {
            return _service.GetAllIngredients();
        }
    }
}
