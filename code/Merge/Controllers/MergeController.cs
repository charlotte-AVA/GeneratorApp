using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
        // applicationUrl: "http://localhost:3889" **SONGS**
        // applicationUrl": "http://localhost:40971" **SINGERS**
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var songsService = "http://localhost:3889";
            var songsResponseCall = await new HttpClient().GetStringAsync(songsService);

            var singersService = "http://localhost:40971";
            var singerssResponseCall = await new HttpClient().GetStringAsync(singersService);

            var mergedResponse = $"{songsResponseCall} in the style of {singerssResponseCall}";
            return Ok(mergedResponse);
        }
    }
}
