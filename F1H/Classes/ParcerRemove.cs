using F1H.Models;
using System.Collections.Generic;
using System.Linq;

namespace F1H.Classes
{
    public class ParcerRemove
    {
        public static IF1HRepository repository;
        public ParcerRemove(IF1HRepository repo) => repository = repo;


        private List<Chassi> listChassis = new List<Chassi>();
        private List<Engine> listEng = new List<Engine>();

        public void RemoveDublicate()
        {
            foreach (var chassis in repository.Chassis.ToList())
            {
                if (listChassis.Where(d => d.Name == chassis.Name && d.IdManufacturer == chassis.IdManufacturer).Count() > 0)
                {
                    repository.RemoveChassi(chassis);
                    repository.SaveChanges();
                }
                else
                {
                    listChassis.Add(chassis);
                }
            }

            foreach (var eng in repository.Engines.ToList())
            {
                if (listEng.Where(d => d.Name == eng.Name && d.IdManufacturer == eng.IdManufacturer).Count() > 0)
                {
                    repository.RemoveEngine(eng);
                    repository.SaveChanges();
                }
                else
                {
                    listEng.Add(eng);
                }
            }
        }

    }
}
