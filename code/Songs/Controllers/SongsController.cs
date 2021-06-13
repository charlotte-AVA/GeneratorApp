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
            "hello",
            "song 2", 
            "song 3",
            "song 4",
            "song 5",
            "song 6",
        }

    }
}
