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
        private string firstPage = "https://wildsoft.motorsport.com/cir.php?l=A&id=61";
        ///html[1]/body[1]/center[1]/div[2]/div[1]/table[1]/tr[2]/td[1]/div[1]/div[6]/a[1]
        ///html[1]/body[1]/center[1]/div[2]/div[1]/table[1]/tr[2]/td[1]/div[1]/div[40]/a[1]

        private string xPathForCollectionsLink = "//href";

        //public int IdCountry { get; set; }
        //public int IdImageGp { get; set; }
        //public string NameEn { get; set; }
        //public string NameRus { get; set; }

        //ImageGPConfiguration

        //public int IdTrack { get; set; }
        //public int IdSeason { get; set; }
        //public int IdImagesGpConfiguration { get; set; }
        //public int Length { get; set; }
        //public int IdImageGp { get; set; }


        public void GetTracks()
        {
            GodLikeHTML.Load(GodLikeClient.OpenRead(firstPage), Encoding);
            var collectionsLink = GodLikeHTML.DocumentNode.Descendants("a").Where(d => d.Attributes.First().ValueLength > 16);


            return;
        }




    }
}
