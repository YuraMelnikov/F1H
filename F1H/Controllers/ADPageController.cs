using System.Linq;
using F1H.Models;
using Microsoft.AspNetCore.Mvc;

namespace F1H.Controllers
{
    public class ADPageController : Controller
    {
        private IF1HRepository repository;
        public ADPageController(IF1HRepository repo) => repository = repo;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Country()
        {
            var country = repository.Country.ToList();
            return View(country);
        }
    }
}