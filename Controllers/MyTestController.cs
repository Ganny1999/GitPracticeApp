using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitPracticeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyTestController : ControllerBase
    {
        [HttpGet("Display")]
        public string Display()
        {
            return "from loca ljdncjlsnclsnclkasnclkasnclkasncdwklckldncjlwnhduol";
        }
        [HttpGet("Display2")]
        public string Display2()
        {
            return "from Remote";
        }
    }
}
