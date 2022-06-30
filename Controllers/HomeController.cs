using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TsukanovaDesign.Domain;
using TsukanovaDesign.Domain.Repositories.EntityFramework;
using TsukanovaDesign.Models;

namespace TsukanovaDesign.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataManager manager;

        public HomeController(ILogger<HomeController> logger, DataManager manager)
        {
            _logger = logger;
            this.manager = manager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Portfolio() 
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contacts() 
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
