using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.MolecularMatchCommonModelClass
{    

    public class FilterList
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }
    }

    public class MolecularFilters
    {
        public MolecularFilters()
        {
            this.BackwardCompatibility = false;
        }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("filters")]
        public List<Filter> Filters { get; set; }

        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Fields { get; set; }

        public List<Filter> ZipcodeFilter { get; set; }

        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string searchTerm { get; set; }

        [JsonProperty("age", NullValueHandling = NullValueHandling.Ignore)]
        public int? Age { get; set; }

        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public string Gender { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public LocationObjectFilter Location { get; set; }

        [JsonProperty("backwardCompatibility", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BackwardCompatibility { get; set; }
    }

    public class LocationObjectFilter
    {

        [JsonProperty("postalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string PostalCode { get; set; }

        [JsonProperty("countryCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }
    }

    public class Filter
    {
        public string facet { get; set; }
        public string term { get; set; }

        [JsonProperty("filterType", NullValueHandling = NullValueHandling.Ignore)]
        public string FilterType { get; set; }

        [JsonProperty("countryCode", NullValueHandling = NullValueHandling.Ignore)]
        public string countryCode { get; set; }

        [JsonProperty("postalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string postalCode { get; set; }
    }

    public class SearchKeyModel
    {
        public SearchKeyModel()
        {
            this.BackwardCompatibility = false;
        }

        [JsonProperty("searchKey")]
        public string SearchKey { get; set; }

        [JsonProperty("start")]
        public long Start { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Fields { get; set; }

        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        public Filter[] Filter { get; set; }

        [JsonProperty("backwardCompatibility", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BackwardCompatibility { get; set; }
    }
}