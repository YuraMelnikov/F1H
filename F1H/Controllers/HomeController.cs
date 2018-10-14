using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using F1H.Classes;
using F1H.Models;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;

namespace F1H.Controllers
{
    public class HomeController : Controller
    {
        private IF1HRepository repository;
        public HomeController(IF1HRepository repo) => repository = repo;

        public IActionResult Index()
        {
            //ParcerCountry parcerCountry = new ParcerCountry(repository);
            //parcerCountry.GetCountry();
            //ParserManufChassi parser = new ParserManufChassi(repository);
            //parser.SaveData();
            return View();
        }


    }
}