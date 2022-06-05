using Newtonsoft.Json;

namespace WebApplication1.MolecularMatchCommonModelClass
{
    public class AutoCompleteRequest
    {
        public AutoCompleteRequest()
        {
            this.Language = "en";
        }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class AutoCompleteSugestions
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("max_score")]
        public object MaxScore { get; set; }

        [JsonProperty("hits")]
        public Hit[] Hits { get; set; }
    }

    public class Hit
    {
        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("facet")]
        public string Facet { get; set; }
    }
}