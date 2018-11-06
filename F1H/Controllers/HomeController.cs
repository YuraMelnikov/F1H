using F1H.Classes;
using F1H.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace F1H.Controllers
{
    public class HomeController : Controller
    {
        private IF1HRepository repository;
        private ILogger<HomeController> logger;
        private bool throwException;

        public HomeController(IF1HRepository repo, ILogger<HomeController> log)
        {
            repository = repo;
            logger = log;
        }

        public IActionResult Index()
        {
            logger.LogDebug($"Handled {Request.Path} at uptime");
            if (throwException)
            {
                throw new System.NullReferenceException();
            }
            return View(new Dictionary<string, string>
            {
                ["Message"] = "This is the Index action"
            });
            //return View();
        }

        public ViewResult Error() => View(nameof(Index),
            new Dictionary<string, string>
            {
                ["Message"] = "This is the Error action"
            });
    }
}