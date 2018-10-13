using F1H.Models;
using System.Collections.Generic;
using System.IO;

namespace F1H.Classes
{
    public class ParcerCountry : Parcer
    {
        public ParcerCountry(IF1HRepository repo)
            : base(repo)
        {
            
        }

        string linkFirstCountry = "https://wildsoft.motorsport.com/cnt.php?id=2";
        string xPathRusName = "/html[1]/body[1]/center[1]/div[2]/div[2]/table[1]/tr[1]/td[1]/p[1]/h1[1]";
        string xPathScrFlag = "/html[1]/body[1]/center[1]/div[2]/div[2]/table[2]/tr[1]/td[1]/img[1]";
        string folderFlag = @"~/Content/Flags/";

        public void GetCountry()
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

            List<CountryLoad> listCountry = new List<CountryLoad>();
            bool correct = false;
            int count = 2;
            while (correct != true)
            {
                try
                {
                    GodLikeHTML.Load(GodLikeClient.OpenRead(linkFirstCountry.Substring(0, linkFirstCountry.Length - 1) + count.ToString()), Encoding);
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
    }
}
