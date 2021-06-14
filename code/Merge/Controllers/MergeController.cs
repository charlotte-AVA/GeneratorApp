using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http; // add namespace to enable service HttpClient for string asysnchronous values from char or int (not needed if alreay string?)
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
            var songsService = "http://localhost:3889/songs";
            var songsResponseCall = await new HttpClient().GetStringAsync(songsService);

            var singersService = "http://localhost:40971/singers";
            var singersResponseCall = await new HttpClient().GetStringAsync(singersService);

            var mergeResponse = $"You will be singing {songsResponseCall} in the style of {singersResponseCall}";
            return Ok(mergeResponse);
        }
    }
}
