using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirMonit_Service.Models
{
    public class Alarm
    {
        public string molecule { get; set; }
        public int value { get; set; }
        public string errorMessage { get; set; }
    }
}