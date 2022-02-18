using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1_HelloWorld
{
    [Route("api/helloWorld")]
    public class HelloWorldController:Controller
    {
        [HttpGet]
        public ActionResult<Object> Greet()
        {
            return Ok(new { message="Hello World" });
        }
    }
}
