using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Singers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SingersController : ControllerBase
    {
        private static readonly string[] Singers = new[]
        {
            "singer 1",
            "singer 2",
            "singer 3",
            "singer 4",
            "singer 5",
            "singer 6",
            "singer 7",
            "singer 8",
            "singer 9",
            "singer 10", 
        };

        [HttpGet]
        public ActionResult<string> Get()
        {
            var rnd = new Random();
            var returnIndex = rnd.Next(0, 10);
            return Singers[returnIndex].ToString();
        }

    }
}
