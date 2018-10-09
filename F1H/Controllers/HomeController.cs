using F1H.Models;
using Microsoft.AspNetCore.Mvc;

namespace F1H.Controllers
{
    public class HomeController : Controller
    {
        private IF1HRepository repository;

        public IActionResult Index()
        {
            return View();
            //return View(repository.Countries);
        }
    }
}