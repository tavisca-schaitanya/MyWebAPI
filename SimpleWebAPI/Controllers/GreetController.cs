using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetController : ControllerBase
    {
        [HttpGet("Talk")]
        public string Talk(string message)
        {
            if (message.ToLower() == "hi")
                return "Hello";

            if (message.ToLower() == "hello")
                return "Hi";

            return "I don't know what you are saying";
        }
    }
}