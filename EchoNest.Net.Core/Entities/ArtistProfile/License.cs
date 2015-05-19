using Newtonsoft.Json;

namespace EchoNest.Net.Core.Entities.ArtistProfile
{

    public class License
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("attribution")]
        public string Attribution { get; set; }

        [JsonProperty("attribution-url")]
        public string AttributionUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

}
