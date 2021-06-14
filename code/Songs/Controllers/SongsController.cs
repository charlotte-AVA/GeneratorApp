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
            "song 1",
            "song 2",
            "song 3",
            "song 4",
            "song 5",
            "song 6",
            "song 7",
            "song 8",
            "song 9",
            "song 10",
            "song 11",
            "song 12",
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
