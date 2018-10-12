using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using F1H.Models;
using HtmlAgilityPack;

namespace F1H.Classes
{
    public class Parcer
    {
        private IF1HRepository repository;
        public Parcer(IF1HRepository repo) => repository = repo;

        string startPagesSite = "https://wildsoft.motorsport.com/";
        WebClient GodLikeClient = new WebClient();
        HtmlDocument GodLikeHTML = new HtmlDocument();
        Encoding encoding = CodePagesEncodingProvider.Instance.GetEncoding(1251);
        
        public void ParcerCountry()
        {
            List<CountryLoad> listCountry = GetListCountryLoad();
            foreach (var DATA in listCountry)
            {
                Country country = new Country();
                country.NameRus = DATA.RusName;
                country.NameEn = "";
                country.IdImageGpFlag = DATA.LinkImage;
                repository.AddCountry(country);
                repository.SaveChanges();
            }
        }

        private List<CountryLoad> GetListCountryLoad()
        {
            string linkFirstCountry = "https://wildsoft.motorsport.com/cnt.php?id=2";
            string xPathRusName = "/html[1]/body[1]/center[1]/div[2]/div[2]/table[1]/tr[1]/td[1]/p[1]/h1[1]";
            string xPathScrFlag = "/html[1]/body[1]/center[1]/div[2]/div[2]/table[2]/tr[1]/td[1]/img[1]";
            string folderFlag = @"~/Content/Flags/";
            List<CountryLoad> listCountry = new List<CountryLoad>();
            bool correct = false;
            int count = 2;
            while (correct != true)
            {
                try
                {
                    GodLikeHTML.Load(GodLikeClient.OpenRead(linkFirstCountry.Substring(0, linkFirstCountry.Length - 1) + count.ToString()), encoding);
                    string rusNameCountry = GetTextDataNode(xPathRusName);
                    if (rusNameCountry == "")
                        break;
                    string img = GetScrDataNode(xPathScrFlag);
                    SaveFileToServer(img, folderFlag);
                    ImageGPFlag imageGPFlag = new ImageGPFlag();
                    imageGPFlag.Link = folderFlag + Path.GetFileName(img);
                    repository.AddImageGPFlag(imageGPFlag);
                    repository.SaveChanges();
                    listCountry.Add(new CountryLoad(rusNameCountry, imageGPFlag.Id));
                }
                catch
                {
                    correct = true;
                }
                count++;
            }
            return listCountry;
        }

        private void SaveFileToServer(string scrFile, string folderUpload)
        {
            GodLikeClient.DownloadFile(startPagesSite + scrFile, Path.Combine(folderUpload, Path.GetFileName(scrFile)));
        }
        
        private string GetTextDataNode(string xPath)
        {
            return GodLikeHTML.DocumentNode.SelectNodes(xPath).First().InnerText;
        }

        private string GetScrDataNode(string xPath)
        {
            return GodLikeHTML.DocumentNode.SelectNodes(xPath).First().Attributes.First().DeEntitizeValue;
        }
    }
}
