using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using F1H.Models;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;

namespace F1H.Controllers
{
    public class HomeController : Controller
    {
        private IF1HRepository repository;
        public HomeController(IF1HRepository repo) => repository = repo;

        private Stream filePath;

        public IActionResult Index()
        {
            ParcerCountry();
            return View();
        }

        public void ParcerCountry()
        {
            string startLinkCountry = "https://wildsoft.motorsport.com/cnt.php?id=2";
            int count = 2;
            List<string> listCountry = new List<string>();
            bool correct = false;
            while (correct != true)
            {
                WebClient GodLikeClient = new WebClient();
                HtmlDocument GodLikeHTML = new HtmlDocument();
                Encoding encoding = CodePagesEncodingProvider.Instance.GetEncoding(1251);
                try
                {
                    GodLikeHTML.Load(GodLikeClient.OpenRead(startLinkCountry.Substring(0, startLinkCountry.Length - 1) + count.ToString()), encoding);
                    var t = GodLikeHTML.DocumentNode.SelectNodes("/html[1]/body[1]/center[1]/div[2]/div[2]/table[1]/tr[1]/td[1]/p[1]/h1[1]");
                    if(t.First().InnerText == "")
                        break;
                    listCountry.Add(t.First().InnerText);
                }
                catch(Exception ex)
                {
                    correct = true;
                }
                count++;
            }
            int x = 0;
        }
    }
}