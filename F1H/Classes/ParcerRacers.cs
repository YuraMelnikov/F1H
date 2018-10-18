using F1H.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1H.Classes
{
    public class ParcerRacers : ParserManufChassi
    {
        public ParcerRacers(IF1HRepository repo)
            : base(repo)
        {

        }

        protected override string IndexLink { get; } = "https://wildsoft.motorsport.com/drv.php?l=";
        protected override string FolderImageLivery { get; } = @"wwwroot/Content/ImageDriver/";
        protected override string XPathMImage { get; } = "/html[1]/body[1]/center[1]/div[3]/div[2]/table[2]/tr[1]/td[1]/img[1]";
        private string nameNode = "//h2";
        private string countryNode = "/html[1]/body[1]/center[1]/div[3]/div[2]/table[1]/tr[1]/td[1]/p[1]";

        private string XPathLive { get; } = "text_mb-5_i-10";

        private string born = "/html[1]/body[1]/center[1]/div[3]/div[2]/table[2]/tr[1]/td[1]/em[1]/td[2]/table[1]/tr[1]/td[2]";
        private string bornIn = "/html[1]/body[1]/center[1]/div[3]/div[2]/table[2]/tr[1]/td[1]/em[1]/td[2]/table[1]/tr[1]/td[3]";
        private string dead = "/html[1]/body[1]/center[1]/div[3]/div[2]/table[2]/tr[1]/td[1]/em[1]/td[2]/table[1]/tr[2]/td[2]";
        private string deadIn = "/html[1]/body[1]/center[1]/div[3]/div[2]/table[2]/tr[1]/td[1]/em[1]/td[2]/table[1]/tr[2]/td[3]";

        public override void SaveData()
        {
            List<string> linksList = GetListLink();
            foreach (var DATA in linksList)
            {
                GodLikeHTML.Load(GodLikeClient.OpenRead(DATA), Encoding);
                Racer racer = new Racer();
                try
                {
                    SaveFileToServer(GetScrDataNode(XPathMImage), FolderImageLivery);
                    ImageGPRacers imageGP = SaveImageRacers(FolderImageLivery + GetScrDataNode(XPathMImage).Replace("img/drv/", "").Replace("wwwroot", ""));
                    racer.IndexPhoto = imageGP.Id;
                }
                catch
                {
                    racer.IndexPhoto = 1;
                }
                string name = GodLikeHTML.DocumentNode.SelectNodes(nameNode).First().InnerText;
                racer.FirstName = GetFirstName(name);
                racer.SecondName = GetSecondName(name);
                string country = GodLikeHTML.DocumentNode.SelectNodes(countryNode).First().InnerText;

                try
                {
                    racer.IdCountry = repository.Country.First(d => d.NameRus == country).Id;
                }
                catch
                {
                    Country countryDb = new Country();
                    countryDb.NameRus = country;
                    countryDb.IdImageGpFlag = 1;
                    countryDb.NameEn = "";
                    repository.AddCountry(countryDb);
                    repository.SaveChanges();
                    racer.IdCountry = countryDb.Id;
                }
                try
                {
                    racer.Born = Convert.ToDateTime(GodLikeHTML.DocumentNode.SelectNodes(born).First().InnerText);
                }
                catch
                {
                    racer.Born = new DateTime();
                }

                try
                {
                    racer.Dead = Convert.ToDateTime(GodLikeHTML.DocumentNode.SelectNodes(dead).First().InnerText);
                }
                catch
                {
                    racer.Dead = new DateTime();
                }

                try
                {
                    racer.BornIn = GodLikeHTML.DocumentNode.SelectNodes(bornIn).First().InnerText;
                }
                catch 
                {
                    racer.BornIn = "";
                }
                
                try
                {
                    racer.DeadIn = GodLikeHTML.DocumentNode.SelectNodes(deadIn).First().InnerText;
                }
                catch
                {
                    racer.DeadIn = "";
                }
                racer.TextData = "";
                try
                {
                    var collectionTextData = GodLikeHTML.DocumentNode.SelectNodes("//p[@class='" + XPathLive + "']");
                    foreach (var VARIABLE in collectionTextData)
                    {
                        racer.TextData += VARIABLE.NextSibling.InnerText;
                    }
                }
                catch
                {

                }
                repository.AddRacer(racer);
                repository.SaveChanges();
            }
        }

        private ImageGPRacers SaveImageRacers(string link)
        {
            ImageGPRacers image = new ImageGPRacers();
            image.Link = link;
            repository.AddImageGPRacers(image);
            repository.SaveChanges();
            return image;
        }

        private string GetFirstName(string name)
        {
            try
            {
                name = name.Substring(0, name.IndexOf(","));
            }
            catch
            {
                name = "";
            }
            return name;
        }

        private string GetSecondName(string name)
        {
            try
            {
                name = name.Substring(name.IndexOf(",") + 2);
            }
            catch
            {
                name = "";
            }
            return name;
        }
    }
}
