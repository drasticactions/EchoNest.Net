using Newtonsoft.Json;

namespace EchoNest.Net.Core.Entities.ArtistProfile
{

    public class Blog
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("date_posted")]
        public string DatePosted { get; set; }

        [JsonProperty("date_found")]
        public string DateFound { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

}
