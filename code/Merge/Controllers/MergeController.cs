using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http; // // added namespace (1)
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration; // added namespace (2)
using Microsoft.Extensions.Logging;

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
        // applicationUrl: "http://localhost:3889" **SONGS**
        // applicationUrl": "http://localhost:40971" **SINGERS**
        private IConfiguration Configuration; 

        public MergeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var songsService = "http://localhost:3889/songs";
            var songsService = $"{Configuration["songsServiceURL"]}/songs";
            var songsResponseCall = await new HttpClient().GetStringAsync(songsService);

            //var singersService = "http://localhost:40971/singers";
            var singersService = $"{Configuration["singersServiceURL"]}/singers";
            var singersResponseCall = await new HttpClient().GetStringAsync(singersService);

            var mergeResponse = $"You will be singing {songsResponseCall} in the style of {singersResponseCall}";
            return Ok(mergeResponse);
        }
    }
}
