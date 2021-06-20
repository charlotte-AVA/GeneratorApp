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
            "SINGER 1",
            "SINGER 2",
            "SINGER 3",
            "SINGER 4",
            "SINGER 5",
            "SINGER 6",
            "SINGER 7",
            "SINGER 8",
            "SINGER 9",
            "SINGER 10", 
        };

        [HttpGet]
        public ActionResult<string> Get()
        {
            var rnd = new Random();
            var returnIndex = rnd.Next(0, 9);
            return Singers[returnIndex].ToString();
        }

    }
}
