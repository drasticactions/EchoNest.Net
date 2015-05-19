using Newtonsoft.Json;

namespace EchoNest.Net.Core.Entities.ArtistProfile
{

    public class DocCounts
    {

        [JsonProperty("biographies")]
        public int Biographies { get; set; }

        [JsonProperty("blogs")]
        public int Blogs { get; set; }

        [JsonProperty("images")]
        public int Images { get; set; }

        [JsonProperty("news")]
        public int News { get; set; }

        [JsonProperty("reviews")]
        public int Reviews { get; set; }

        [JsonProperty("songs")]
        public int Songs { get; set; }

        [JsonProperty("videos")]
        public int Videos { get; set; }
    }

}
