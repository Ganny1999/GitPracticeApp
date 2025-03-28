﻿using Microsoft.AspNetCore.Http;
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
        [HttpGet("NewGetList")]
        public string NewGetList()
        {
            return "New feature added.";
        }
        [HttpGet("NewGetList1")]
        public string NewGetList1()
        {
            return "New feature added.";
        }
    }
}
