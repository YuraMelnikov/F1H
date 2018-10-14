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

        string xPathCName = "//html[1]/body[1]/center[1]/div[3]/div[2]/table[3]/tr[1]/td[1]/b[1]/td[1]/b[1]/td[1]/b[1]/td[1]/b[1]/tr/td[2]";
        string xPathCImageLiver = "";
        string folderImageLivery = @"~/Content/Livery/";

        ///html[1]/body[1]/center[1]/div[3]/div[2]/table[3]/tr[1]/td[1]/b[1]/td[1]/b[1]/td[1]/b[1]/td[1]/b[1]/tr[1]/td[2]/#text[1]
        ///html[1]/body[1]/center[1]/div[3]/div[2]/table[3]/tr[1]/td[1]/b[1]/td[1]/b[1]/td[1]/b[1]/td[1]/b[1]/tr[3]/td[2]/#text[1]



        public void SaveData()
        {
            //Chassi = IdManufacturer + Name + 1 + IdImagesGpChassi(Save or null1)
            List<string> linksList = GetListLink();
            foreach(var DATA in linksList)
            {
                //Create Image
                GodLikeHTML.Load(GodLikeClient.OpenRead(DATA), Encoding);
                SaveFileToServer(GetScrDataNode(xPathMImage), folderImageManuf);
                ImageGP imageGP = SaveImage(folderImageManuf + GetScrDataNode(xPathMImage).Replace("img/cha/small/", ""));

                //CreateMan
                string mName = GetTextDataNode(xPathMName);
                Manufacturer manufacturer = CreateManufacturer(mName, imageGP.Id);


                List<ChassiLoad> listChassis = GetChassiLoads(mName, manufacturer.Id);
            }
        }


        private List<ChassiLoad> GetChassiLoads(string mName, int idM)
        {
            List<ChassiLoad> listChassis = new List<ChassiLoad>();
            var collectionNames = GodLikeHTML.DocumentNode.SelectNodes(xPathCName).Where(d => d.InnerHtml != d.InnerText);

            foreach (var DATA in collectionNames)
            {
                if (listChassis.Where(d => d.Name == DATA.InnerText).Count() == 0)
                {
                    string linkImage = "";
                    int idImageLiver = 1;
                    try
                    {
                        linkImage = DATA.ChildNodes.Where(d => d.Name == "img").First().Attributes.First().DeEntitizeValue;
                    }
                    catch
                    {

                    }
                    if(linkImage != "")
                    {
                        //SaveFileToServer(linkImage, folderImageLivery);
                        ImageGPLiver image = SaveimageLiver(folderImageLivery + linkImage.Replace("img/cha/mod/", ""));
                        idImageLiver = image.Id;
                    }
                    ChassiLoad chassiLoad = new ChassiLoad(DATA.InnerText, idImageLiver);
                    Chassi chassi = new Chassi();
                    chassi.IdManufacturer = idM;
                    chassi.Name = DATA.InnerText.Replace(mName + " ", "");
                    chassi.IdImageGp = 1;
                    chassi.IdImagesGpChassi = idImageLiver;
                    repository.AddChassi(chassi);
                    repository.SaveChanges();
                }
            }


            return listChassis;
        }


        private ImageGPLiver SaveimageLiver(string link)
        {
            ImageGPLiver image = new ImageGPLiver();
            image.Link = link;
            repository.AddImageGPLiver(image);
            repository.SaveChanges();
            return image;
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


        private ImageGPLiver SaveImageGPLiver(string link)
        {
            ImageGPLiver imageGP = new ImageGPLiver();
            imageGP.Link = link;
            repository.AddImageGPLiver(imageGP);
            repository.SaveChanges();
            return imageGP;
        }
    }
}
