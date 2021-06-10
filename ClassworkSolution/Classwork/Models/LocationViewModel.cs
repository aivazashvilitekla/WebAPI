using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Classwork.Models
{
    public class LocationViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public double Longtitude { get; set; }

        public double Latitude { get; set; }
        public int? ParentID { get; set; }
    }
}