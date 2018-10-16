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
            foreach (var DATA in linksList)
            {
                GodLikeHTML.Load(GodLikeClient.OpenRead(DATA), Encoding);
                string mName = GetTextDataNode(xPathMName);
                Manufacturer manufacturer = CreateManufacturer(mName, firstIdImages);
                List<ChassiLoad> listChassis = GetChassiLoads(mName, manufacturer.Id);
            }
        }
        //
        private List<ChassiLoad> GetChassiLoads(string mName, int idM)
        {
            List<ChassiLoad> listChassis = new List<ChassiLoad>();
            
            var collectionNames = GodLikeHTML.DocumentNode.SelectNodes("//td[@class='" + XPathCName + "']");
            foreach (var DATA in collectionNames)
            {
                if(DATA.XPath.Substring(DATA.XPath.Length - 2, 1) != "2")
                {
                    continue;
                }
                if (listChassis.Where(d => d.Name == DATA.InnerText).Count() == 0)
                {
                    Engine engine = new Engine();
                    engine.IdManufacturer = idM;
                    engine.Name = DATA.InnerText.Replace(mName + " ", "");
                    engine.IdImageGp = firstIdImages;
                    repository.AddEngine(engine);
                    repository.SaveChanges();
                }
            }
            return listChassis;
        }
    }
}
