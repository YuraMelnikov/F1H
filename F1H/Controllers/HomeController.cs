using System;
using System.Collections.Generic;
using System.IO;
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
        private Stream filePath;

        public IActionResult Index()
        {
            TestParcer();
            return View();
        }

        public void TestParcer()
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
                    var t = GodLikeHTML.DocumentNode.SelectNodes("//html/body/table/tbody/");
                    var yy = 1;
                    
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