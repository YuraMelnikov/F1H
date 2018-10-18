using F1H.Models;
using System.Collections.Generic;
using System.Linq;

namespace F1H.Classes
{
    public class ParcerEngine : ParserManufChassi
    {
        public ParcerEngine(IF1HRepository repo)
            : base(repo)
        {

        }
        
        protected override string IndexLink { get; } = "https://wildsoft.motorsport.com/eng.php?l=";
        protected override string XPathCName { get; } = "cell_cla_br-rt";

        public override void SaveData()
        {
            List<string> linksList = GetListLink();
            foreach (var data in linksList)
            {
                GodLikeHTML.Load(GodLikeClient.OpenRead(data), Encoding);
                string mName = GetTextDataNode(xPathMName);
                Manufacturer manufacturer = CreateManufacturer(mName, firstIdImages);
                List<ChassiLoad> listChassis = GetChassiLoads(mName, manufacturer.Id);
            }
        }

        protected override List<ChassiLoad> GetChassiLoads(string mName, int idM)
        {
            List<ChassiLoad> listChassis = new List<ChassiLoad>();
            
            var collectionNames = GodLikeHTML.DocumentNode.SelectNodes("//td[@class='" + XPathCName + "']");
            foreach (var data in collectionNames)
            {
                if(data.XPath.Substring(data.XPath.Length - 2, 1) != "2")
                {
                    continue;
                }
                if (listChassis.All(d => d.Name != data.InnerText.Replace(mName + " ", "")))
                {
                    Engine engine = new Engine
                    {
                        IdManufacturer = idM,
                        Name = data.InnerText.Replace(mName + " ", ""),
                        IdImageGp = firstIdImages
                    };
                    repository.AddEngine(engine);
                    repository.SaveChanges();
                }
            }
            return listChassis;
        }
    }
}
