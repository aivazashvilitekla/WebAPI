using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    public class Location
    {
        public string Name { get; set; }

        public double Longtitude { get; set; }

        public double Latitude { get; set; }
        public int? ParentID { get; set; }
    }
}
