using Newtonsoft.Json;

namespace EchoNest.Net.Core.Entities.ArtistProfile
{

    public class ArtistLocation
    {

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("region")]
        public object Region { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

}
