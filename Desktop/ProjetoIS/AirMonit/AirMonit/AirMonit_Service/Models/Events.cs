using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirMonit_Service.Models
{
    public class Events
    {
        public string userId { get; set; }
        public string description { get; set; }
        public int temp { get; set; }
        public string airQual { get; set; }
        public int value { get; set; }
        public DateTime date { get; set; }
        public string local { get; set; }
    }
}