using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using F1H.Models;

namespace F1H.Classes
{
    public class ParserTracks : Parcer
    {
        public ParserTracks(IF1HRepository repo)
            : base(repo)
        {

        }

        private string FolderTrackConf { get; } = @"wwwroot/Content/TrackConf/";
        private string firstPage = "https://wildsoft.motorsport.com/cir.php?l=A";
        private string xPathForCollectionsLink = "/html[1]/body[1]/center[1]/div[2]/div[1]/table[1]/tr[2]/td[1]/div[1]/div/a[1]";
        private string xPathRusName = "//h1";
        private string xPathEngName = "//h2";
        private string xPathCountry = "//p[@class='" + "text_m-0" + "']";
        private string xPathConfCollection = "//td[@class='" + "cell_cla_br-rt" + "']";
        
        public void GetTracks()
        {
            GodLikeHTML.Load(GodLikeClient.OpenRead(firstPage), Encoding);
            var collectionsLink = GodLikeHTML.DocumentNode.SelectNodes(xPathForCollectionsLink);
            List <string> coList = new List<string>();
            foreach (var VARIABLE in collectionsLink)
            {
                coList.Add(StartPagesSite + VARIABLE.Attributes.First().Value);
            }
            foreach (var VARIABLE in coList)
            {
                SaveDataTrack(VARIABLE);
            }
        }

        private void SaveDataTrack(string link)
        {
            GodLikeHTML.Load(GodLikeClient.OpenRead(link), Encoding);
            Track track = new Track
            {
                NameRus = GodLikeHTML.DocumentNode.SelectNodes(xPathRusName)[2].InnerText,
                NameEn = GodLikeHTML.DocumentNode.SelectNodes(xPathEngName).First().InnerText,
                IdImageGp = 1
            };
            string countryName = GodLikeHTML.DocumentNode.SelectNodes(xPathCountry).First().InnerText;
            try
            {
                track.IdCountry = repository.Country.First(d => d.NameRus == countryName).Id;
            }
            catch
            {
                Country country = new Country
                {
                    IdImageGpFlag = 1,
                    NameEn = "",
                    NameRus = countryName
                };
                repository.AddCountry(country);
                repository.SaveChanges();
                track.IdCountry = country.Id;
            }
            repository.AddTrack(track);
            repository.SaveChanges();
            SaveDataTrackConfiguration(track.Id);
        }

        private void SaveDataTrackConfiguration(int idTrack)
        {
            var collectionConf = GodLikeHTML.DocumentNode.SelectNodes(xPathConfCollection);
            for (int i = 0; i < collectionConf.Count; i += 2)
            {
                TrackСonfiguration trackСonfiguration = new TrackСonfiguration();
                trackСonfiguration.IdImageGp = 1;
                trackСonfiguration.Length = Convert.ToInt32(collectionConf[i + 1].InnerText.Replace(" ", ""));
                trackСonfiguration.IdImagesGpConfiguration = SaveFileToServer(collectionConf[i].ChildNodes.First().ChildNodes.First().Attributes[0].Value, FolderTrackConf);
                trackСonfiguration.IdTrack = idTrack;
                try
                {
                    trackСonfiguration.IdSeason = GetSeasons(collectionConf[i].ChildNodes.First().ChildNodes.First().Attributes[4].Value);
                }
                catch
                {
                    trackСonfiguration.IdSeason = repository.Seasons.First(d => d.Year == 2018).Id;
                }

                try
                {
                    trackСonfiguration.Name = GetName(collectionConf[i].ChildNodes.First().ChildNodes.First().Attributes[4].Value);
                }
                catch (Exception e)
                {
                    trackСonfiguration.Name = "NA";
                }

                repository.AddTrackСonfiguration(trackСonfiguration);
                repository.SaveChanges();
            }
            return;
        }

        private int SaveFileToServer(string scrFile, string folderUpload)
        {
            try
            {
                GodLikeClient.DownloadFile(startPagesSite + scrFile, Path.Combine(folderUpload, Path.GetFileName(scrFile)));
                ImageGPTrackConfiguration imageGpConfiguration = new ImageGPTrackConfiguration();
                imageGpConfiguration.Link = FolderTrackConf + scrFile.Replace("img/cir/small/", "");
                repository.AddImageGPConfiguration(imageGpConfiguration);
                repository.SaveChanges();
                return imageGpConfiguration.Id;
            }
            catch
            {
                return 1;
            }

        }

        private string GetName(string name)
        {
            int index = name.Length;
            index = name.IndexOf("19");
            if(index < 1)
                index = name.IndexOf("20");
            return name.Substring(0, index);
        }

        private int GetSeasons(string name)
        {
            try
            {
                return repository.Seasons.First(d => d.Year == Convert.ToInt32(name.Substring(name.Length - 9, 4))).Id;
            }
            catch
            {
                return repository.Seasons.First(d => d.Year == Convert.ToInt32(name.Substring(name.Length - 4, 4))).Id;
            }
        }
    }
}
