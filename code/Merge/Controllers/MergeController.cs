using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http; // // added namespace (1)
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration; // added namespace (2)
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;//added namespace

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
        // SONGS Url: "http://localhost:3889"
        // SINGERS Url: "http://localhost:40971" 

        //private IConfiguration Configuration; 
        //public MergeController(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        private AppSettings Configuration;
        public MergeController(IOptions<AppSettings> settings)
        {
            Configuration = settings.Value; 
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var songsService = "http://localhost:3889/songs";
            //var songsService = $"{Configuration["songsServiceURL"]}/songs";
            var songsService = "https://cemtest1.azurewebsites.net/songs";
            var songsResponseCall = await new HttpClient().GetStringAsync(songsService);

            //var singersService = "http://localhost:40971/singers";
            //var singersService = $"{Configuration["singersServiceURL"]}/singers";
            var singersService = "https://cemtest2.azurewebsites.net/singers";
            var singersResponseCall = await new HttpClient().GetStringAsync(singersService);

            var mergeResponse = $"You will be singing {songsResponseCall} in the style of {singersResponseCall}";
            return Ok(mergeResponse);
        }
    }
}
