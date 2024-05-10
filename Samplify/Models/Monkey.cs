using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samplify.Models
{
    public class Monkey
    {
        public string Name { get; set; }
        public long Population { get; set; }
        public string Image { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string Url { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
}
