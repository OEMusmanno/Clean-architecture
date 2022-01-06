using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nubimetrics.DalEntities.SearchItem
{
    public class Item
    {
        public string site_id { get; set; }
        public string country_default_time_zone { get; set; }
        public string query { get; set; }
        public Paging paging { get; set; }
        public List<Result> results { get; set; }
        public Sort sort { get; set; }
        public List<AvailableSort> available_sorts { get; set; }
        public List<Filter> filters { get; set; }
        public List<AvailableFilter> available_filters { get; set; }
    }
   
    public class Result
    {
        public string id { get; set; }
        public string site_id { get; set; }
        public string title { get; set; }
        public double price { get; set; }
        public int seller_Id { get; set; }
        public string permalink { get; set; }
    }
}
