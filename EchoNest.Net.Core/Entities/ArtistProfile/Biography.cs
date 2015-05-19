using Newtonsoft.Json;

namespace EchoNest.Net.Core.Entities.ArtistProfile
{

    public class Biography
    {

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("site")]
        public string Site { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("license")]
        public License License { get; set; }

        [JsonProperty("truncated")]
        public bool Truncated { get; set; }
    }

}
