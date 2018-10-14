using F1H.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace F1H.Classes
{
    public class ParserManufChassi : Parcer
    {

        public ParserManufChassi(IF1HRepository repo)
          : base(repo)
        {

        }
        string indexLink = "https://wildsoft.motorsport.com/cha.php?l=";
        string xPathLinkData1 = "html[1]/body[1]/center[1]/div[3]/div[1]/table[1]/tr[2]/td[1]/div[1]/div[";
        string xPathLinkData2 = "]/a[1]/@href[1]";

        string xPathMName = "/html[1]/body[1]/center[1]/div[3]/div[2]/table[1]/tr[1]/td[1]/p[1]/h1[1]";
        string xPathMImage = "/html[1]/body[1]/center[1]/div[3]/div[1]/table[1]/tr[2]/td[1]/div[1]/div[1]/img[1]";
        string folderImageManuf = @"~/Content/ImagesManufacturing/";

        string xPathCName = "\\name";

        
        public void SaveData()
        {
            //Chassi = IdManufacturer + Name + 1 + IdImagesGpChassi(Save or null1)
            List<string> linksList = GetListLink();
            foreach(var DATA in linksList)
            {
                ////Create Image
                GodLikeHTML.Load(GodLikeClient.OpenRead(DATA), Encoding);
                //SaveFileToServer(GetScrDataNode(xPathMImage), folderImageManuf);
                //ImageGP imageGP = SaveImage(folderImageManuf + GetScrDataNode(xPathMImage).Replace("img/cha/small/", ""));

                ////CreateMan
                ////GodLikeHTML.Load(GodLikeClient.OpenRead(DATA), Encoding);
                //string mName = GetTextDataNode(xPathMName);
                //Manufacturer manufacturer = CreateManufacturer(mName, imageGP.Id);


                List<ChassiLoad> listChassis = GetChassiLoads();
                //ColChass
                //////Name - проверка от повторяемости
                //////IdImagesGpChassi - null
                ///

                int x = 0;


            }
        }


        private List<ChassiLoad> GetChassiLoads()
        {
            List<ChassiLoad> listChassis = new List<ChassiLoad>();
            var x = GodLikeHTML.DocumentNode.SelectNodes(xPathCName);

            return listChassis;
        }

        private List<string> GetListLink()
        {
            List<string> listLink = new List<string>();
            for(int i = 65; i <= 65; i++) //90
            {
                bool correct = false;
                int counterStep = 1;
                string tmp = Convert.ToChar(i).ToString();
                GodLikeHTML.Load(GodLikeClient.OpenRead(indexLink + Convert.ToChar(i).ToString()), Encoding);
                while(correct != true)
                {
                    try
                    {
                        string linkManufacture = GodLikeHTML.DocumentNode.SelectNodes(xPathLinkData1 + counterStep + xPathLinkData2).First().Attributes.First().DeEntitizeValue;
                        listLink.Add(StartPagesSite + linkManufacture);
                        counterStep++;
                    }
                    catch
                    {
                        correct = true;
                    }
                }
            }
            return listLink;
        }

    }
}
