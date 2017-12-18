using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirMonit_Service.Models
{
    public class Statistics
    {
        public int min { get; set; }
        public int max { get; set; }
        public int avg { get; set; }
        public DateTime Date { get; set; }
        public string local { get; set; }

    }
}