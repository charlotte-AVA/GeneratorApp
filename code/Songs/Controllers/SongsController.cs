using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Songs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongsController : ControllerBase
    {
        private static readonly string[] Songs = new[]
        {
            "SONG 1",
            "SONG 2",
            "SONG 3",
            "SONG 4",
            "SONG 5",
            "SONG 6",
            "SONG 7",
            "SONG 8",
            "SONG 9",
            "SONG 10",
            "SONG 11",
            "SONG 12",
        };

        [HttpGet]
        public ActionResult<string> Get()
        {
            var rnd = new Random();
            var returnIndex = rnd.Next(0, 12);
            return Songs[returnIndex].ToString();
        }
    }
}
