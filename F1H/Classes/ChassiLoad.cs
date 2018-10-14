using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1H.Classes
{
    public class ChassiLoad
    {
        string name;
        int linkImage;

        public ChassiLoad(string name, int linkImage)
        {
            this.Name = name;
            this.LinkImage = linkImage;
        }

        public string Name { get => name; set => name = value; }
        public int LinkImage { get => linkImage; set => linkImage = value; }
    }
}
