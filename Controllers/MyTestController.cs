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
            return "Final changes from local.";
        }
        [HttpGet("Display2")]
        public string Display2()
        {
            return "from Remote";
        }
        [HttpPost("PostMethod")]
        public string Post()
        {
            return "Post method";
        }
        [HttpGet("NewFearture")]
        public string NewFearture()
        {
            return "New feature added.";
        }
    }
}
