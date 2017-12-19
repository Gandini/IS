using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirMonit_Service.Models
{
    public class SensorValue
    {
        public int value { get; set; }
        public DateTime date { get; set; }
        public string local { get; set; }
    }
}