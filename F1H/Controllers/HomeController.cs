﻿using F1H.Classes;
using F1H.Models;
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
            //ParserManufChassi parserManufChassi = new ParserManufChassi(repository);
            //parserManufChassi.SaveData();
            //ParcerEngine parcerEngine = new ParcerEngine(repository);
            //parcerEngine.SaveData();
            //ParcerRacers parcerRacers = new ParcerRacers(repository);
            //parcerRacers.SaveData();
            //ParserTyre parserTyre = new ParserTyre(repository);
            //parserTyre.CreateTyre();

            return View();
        }


    }
}