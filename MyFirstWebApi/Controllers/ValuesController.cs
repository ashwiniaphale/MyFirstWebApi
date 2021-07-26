using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public List<string> Get()
        {
            return new List<string> { "hi", "hello" }; 
        }

        [HttpGet("{a}")]
        public String Get(int a)
        {
            if(a == 1)
            {
                return "ATL"; 
            }
            else if (a > 1)
            {
                return "SLC";
            }
            else
            {
                return "NYC"; 
            }
        }
    }
}
