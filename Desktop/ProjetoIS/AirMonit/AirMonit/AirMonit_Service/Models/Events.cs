using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirMonit_Service.Models
{
    public class Event
    {
<<<<<<< HEAD
        public string userId { get; set; }
=======
        public int userId { get; set; }
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
        public string event_description { get; set; }
        public int temperature  { get; set; }
        public string air_quality { get; set; }
        public int value { get; set; }
        public DateTime date { get; set; }
        public string City_name  { get; set; }
    }
}