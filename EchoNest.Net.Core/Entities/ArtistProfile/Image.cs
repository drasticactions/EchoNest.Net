using Newtonsoft.Json;

namespace EchoNest.Net.Core.Entities.ArtistProfile
{

    public class Image
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("tags")]
        public object[] Tags { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("license")]
        public License License { get; set; }
    }

}
