using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nubimetrics.DalEntities.Country
{
    public class State
    {
        [JsonProperty("Id")]
        public string id { get; set; }

        [JsonProperty("Name")]
        public string name { get; set; }
    }
}
