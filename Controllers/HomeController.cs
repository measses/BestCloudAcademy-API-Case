using Microsoft.AspNetCore.Mvc;

namespace BestCloudCase_API.Controllers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        // GET /
        [HttpGet("/")]
        public IActionResult GetMessage()
        {
            return Ok(new { msg = "BC4M" });
        }

        // GET /health
        [HttpGet("/health")]
        public IActionResult GetHealthStatus()
        {
            return Ok(new { status = "Healthy" });
        }


        // POST /
        [HttpPost("/")]
        public IActionResult EchoData([FromBody] object data)
        {
            return Ok(data);
        }
    }
}
