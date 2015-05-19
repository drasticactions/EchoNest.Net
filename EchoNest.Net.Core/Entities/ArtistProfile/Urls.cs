using Newtonsoft.Json;

namespace EchoNest.Net.Core.Entities.ArtistProfile
{

    public class Urls
    {

        [JsonProperty("official_url")]
        public string OfficialUrl { get; set; }

        [JsonProperty("lastfm_url")]
        public string LastfmUrl { get; set; }

        [JsonProperty("twitter_url")]
        public string TwitterUrl { get; set; }

        [JsonProperty("myspace_url")]
        public string MyspaceUrl { get; set; }

        [JsonProperty("wikipedia_url")]
        public string WikipediaUrl { get; set; }

        [JsonProperty("mb_url")]
        public string MbUrl { get; set; }
    }

}
