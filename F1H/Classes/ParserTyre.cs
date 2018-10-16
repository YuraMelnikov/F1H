using F1H.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1H.Classes
{
    public class ParserTyre
    {
        protected IF1HRepository repository;
        public ParserTyre(IF1HRepository repo) => repository = repo;

        public void CreateTyre()
        {
            List<string> listTyre = new List<string>();
            listTyre.Add("Avon");
            listTyre.Add("Brodgestone");
            listTyre.Add("Continental");
            listTyre.Add("Dunlop");
            listTyre.Add("Englebert");
            listTyre.Add("Firestone");
            listTyre.Add("Goodyear");
            listTyre.Add("Michelin");
            listTyre.Add("Pirelli");

            foreach (var VARIABLE in listTyre)
            {
                Manufacturer manufacturer = new Manufacturer();
                manufacturer.IdCountry = 1;
                manufacturer.IdImageGp = 1;
                manufacturer.Name = VARIABLE;
                repository.AddManufacturer(manufacturer);
                repository.SaveChanges();
                Tyre tyre = new Tyre();
                tyre.IdManufacturer = manufacturer.Id;
                tyre.Name = VARIABLE;
                tyre.IdImageGp = 1;
                repository.AddTyre(tyre);
                repository.SaveChanges();
            }
        }

    }
}
