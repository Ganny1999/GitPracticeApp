using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitPracticeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyTestController : ControllerBase
    {
        [HttpGet]
        public string Display()
        {
            return "from local";
        }
        [HttpGet]
        public string Display()
        {
            return "from Remote";
        }
    }
}
