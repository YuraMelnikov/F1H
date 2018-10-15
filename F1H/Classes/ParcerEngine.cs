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

        protected override string XPathCName { get; } =
            "//html[1]/body[1]/center[1]/div[3]/div[2]/table[3]/tr[1]/td[1]/b[1]/td[1]/b[1]/td[1]/b[1]/td[1]/b[1]/tr/td[2]";

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
        
        private List<ChassiLoad> GetChassiLoads(string mName, int idM)
        {
            List<ChassiLoad> listChassis = new List<ChassiLoad>();


            //incorrect Noda
            var collectionNames = GodLikeHTML.DocumentNode.SelectNodes(XPathCName).Where(d => d.InnerHtml != d.InnerText);
            foreach (var DATA in collectionNames)
            {
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
