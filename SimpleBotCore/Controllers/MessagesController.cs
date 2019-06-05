using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleBotCore.Controllers
{
    [Route("api/[controller]")]
    public class MessagesController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }

        // POST api/messages
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
    }
}
