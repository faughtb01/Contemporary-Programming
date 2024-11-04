using Microsoft.AspNetCore.Mvc;

namespace GitWebAPIPractice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Name = "Brian Faught" });
        }
    }
}
