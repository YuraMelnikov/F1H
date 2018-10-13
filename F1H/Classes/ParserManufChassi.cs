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



        public void SaveData()
        {
            //Man = NAme + 1Country + Images(Save)
            //Chassi = IdManufacturer + Name + 1 + IdImagesGpChassi(Save or null1)




            List<string> linksList = GetListLink();
            foreach(var DATA in linksList)
            {

                //NameMan
                GodLikeHTML.Load(GodLikeClient.OpenRead(DATA), Encoding);
                string mName = GetTextDataNode(xPathMName);
                //SaveImage
                GodLikeHTML.Load(GodLikeClient.OpenRead(DATA), Encoding);
                SaveFileToServer(GetScrDataNode(xPathMImage), folderImageManuf);
                //delete /img/cnt/
                ImageGP imageGP = SaveImage(folderImageManuf + "");


                //CreateMan

                //ColChass
                //////Name
                //////IdImagesGpChassi - null
                ///

                int x = 0;


            }



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
