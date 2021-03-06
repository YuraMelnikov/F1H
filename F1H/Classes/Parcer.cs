﻿using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using F1H.Models;
using HtmlAgilityPack;

namespace F1H.Classes
{
    public class Parcer
    {
        protected int firstIdImages = 1;
        protected int firstIdImagesLivery = 1;

        protected IF1HRepository repository;
        public Parcer(IF1HRepository repo) => repository = repo;
        WebClient godLikeClient = new WebClient();
        HtmlDocument godLikeHTML = new HtmlDocument();
        protected string startPagesSite = "https://wildsoft.motorsport.com/";
        Encoding encoding = CodePagesEncodingProvider.Instance.GetEncoding(1251);

        public WebClient GodLikeClient { get => godLikeClient; set => godLikeClient = value; }
        public HtmlDocument GodLikeHTML { get => godLikeHTML; set => godLikeHTML = value; }
        public string StartPagesSite { get => startPagesSite; set => startPagesSite = value; }
        public Encoding Encoding { get => encoding; set => encoding = value; }

        protected string GetScrDataNode(string xPath)
        {
            try {
                return GodLikeHTML.DocumentNode.SelectNodes(xPath).First().Attributes.First().DeEntitizeValue;
            }
            catch {
                return "";
            }
            
        }
        protected void SaveFileToServer(string scrFile, string folderUpload)
        {
            GodLikeClient.DownloadFile(startPagesSite + scrFile, Path.Combine(folderUpload, Path.GetFileName(scrFile)));
        }
        protected ImageGP SaveImage(string link)
        {
            ImageGP imageGP = new ImageGP();
            imageGP.Description = "";
            imageGP.Size = 0;
            imageGP.Link = link.Replace("wwwroot", "");
            repository.AddImageGP(imageGP);
            repository.SaveChanges();
            return imageGP;
        }

        protected Manufacturer CreateManufacturer(string name, int idImageGp)
        {
            Manufacturer manufacturer = new Manufacturer();
            manufacturer.Id = 0;
            manufacturer.IdCountry = 1;
            manufacturer.Name = name;
            manufacturer.IdImageGp = idImageGp;
            if (repository.Manufacturers.Count(d => d.Name == manufacturer.Name) == 0)
            {
                repository.AddManufacturer(manufacturer);
                repository.SaveChanges();
                return manufacturer;
            }
            else
            {
                return repository.Manufacturers.First(d => d.Name == manufacturer.Name);
            }
        }
            
        protected string GetTextDataNode(string xPath)
        {
            return GodLikeHTML.DocumentNode.SelectNodes(xPath).First().InnerText;
        }


        public void CrateDefaultData()
        {
            ImageGP imageGP = new ImageGP
            {
                Link = "",
                Description = "",
                Size = 0
            };
            repository.AddImageGP(imageGP);
            ImageGPTrackConfiguration imageGpConfiguration = new ImageGPTrackConfiguration
            {
                Link = ""
            };
            repository.AddImageGPConfiguration(imageGpConfiguration);
            ImageGPLivery lmGpLiver = new ImageGPLivery
            {
                Link = ""
            };
            repository.AddImageGPLiver(lmGpLiver);
            ImageGPRacers imageGpRacers = new ImageGPRacers
            {
                Link = ""
            };
            repository.AddImageGPRacers(imageGpRacers);
            TypeCalculate typeCalculate = new TypeCalculate
            {
                Name = "",
                DescriptionEn = "",
                DescriptionRus = ""
            };
            repository.AddTypeCalculate(typeCalculate);
            repository.SaveChanges();
            CreateSeasons();
        }

        public void CreateSeasons()
        {
            for (int i = 1950; i < 2019; i++)
            {
                Season season = new Season
                {
                    IdImageGp = 1,
                    IdTypeCalculate = 1,
                    Year = i
                };
                repository.AddSeason(season);
                repository.SaveChanges();
            }
        }
    }
}
