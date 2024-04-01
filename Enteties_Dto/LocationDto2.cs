using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties_Dto
{
    public class LocationDto2
    {
        public string Book { get; set; }
        public string Chapter { get; set; }
        public string Verse { get; set; }
        public override string ToString()
        {
            return Book + " " + " " + Chapter + " " + Verse + "\n";
        }
    }
}
