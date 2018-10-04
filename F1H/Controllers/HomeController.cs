using F1H.Models;
using Microsoft.AspNetCore.Mvc;

namespace F1H.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;

        public IActionResult Index()
        {
            return View(repository.Countries);
        }
    }
}