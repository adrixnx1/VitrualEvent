using System;
using System.Collections.Generic;

namespace VirtualEvent_WEB.Model
{
    public static class TripStore
    {
        public static List<Trip> Trips { get; set; } = new List<Trip>();
    }

    public class Trip
    {
        public string TripName { get; set; }
        public string Country { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
    }
}
