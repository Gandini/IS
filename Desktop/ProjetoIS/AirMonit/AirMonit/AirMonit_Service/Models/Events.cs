using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirMonit_Service.Models
{
    public class Event
    {
        public string userId { get; set; }
        public string Uncommon_event_description { get; set; }
        public int Temperature_in_celcius_degrees { get; set; }
        public string airQual { get; set; }
        public int value { get; set; }
        public DateTime date { get; set; }
        public string City_name  { get; set; }
    }
}