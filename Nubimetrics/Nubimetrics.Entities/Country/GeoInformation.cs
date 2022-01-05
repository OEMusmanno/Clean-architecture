using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nubimetrics.DalEntities.Country
{
    public class GeoInformation
    {
        [JsonProperty("location")]
        public Location location { get; set; }
    }

    public class Location 
    {
        [JsonProperty("Latitude")]
        public double latitude { get; set; }

        [JsonProperty("Longitude")]
        public double longitude { get; set; }
    }
}
