using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FrontEnd.Models;
using System.Net.Http;

namespace FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        // applicationUrl": "http://localhost:43813" **MERGE**
        public async Task<IActionResult> Index()
        {
            var mergeService = "http://localhost:43813/merge";
            var mergeResponseCall = await new HttpClient().GetStringAsync(mergeService);
            ViewBag.responseCall = mergeResponseCall;
            return View();
        }
    }
}
