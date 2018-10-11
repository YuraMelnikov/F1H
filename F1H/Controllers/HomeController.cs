using System.IO;
using System.Linq;
using System.Net;
using F1H.Models;
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
            //return View(repository.Countries);
        }

        private static Stream GetStreamFromUrl(string url)
        {
            byte[] imageData = null;
            using (var wc = new System.Net.WebClient())
                imageData = wc.DownloadData(url);
            return new MemoryStream(imageData);
        }

        public void TestParcer()
        {
            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
            // There are various options, set as needed
            htmlDoc.OptionFixNestedTags = true;
            filePath = GetStreamFromUrl("http://logicalerrors.com/");
            // filePath is a path to a file containing the html
            htmlDoc.Load(filePath);
            // Use:  htmlDoc.LoadHtml(xmlString);  to load from a string (was htmlDoc.LoadXML(xmlString)
            // ParseErrors is an ArrayList containing any errors from the Load statement
            if (htmlDoc.ParseErrors != null && htmlDoc.ParseErrors.Count() > 0)
            {

                //var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");
                var node = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='main_content']");
                int x = 0;
                // Handle any parse errors as required
            }
            else
            {

            }

        }
    }
}