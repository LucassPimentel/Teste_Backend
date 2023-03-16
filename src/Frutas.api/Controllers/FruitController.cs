using Microsoft.AspNetCore.Mvc;

namespace FrutasBackEnnd.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class FruitController : Controller
    {

        public IActionResult GetAllFruits()
        {
            return Ok();
        }

    }
}
