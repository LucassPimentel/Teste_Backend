
using Frutas.Core.Models;
using Frutas.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace FrutasBackEnnd.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class FruitController : Controller
    {
        private readonly FruitService _fruitService;

        public FruitController(FruitService fruitService)
        {
            _fruitService = fruitService;
        }

        [HttpGet("GetFruits")]
        public IActionResult GetAllFruits()
        {
            var fruits = _fruitService.GetAllFruits();
            return Ok(fruits);
        }
    }
}
