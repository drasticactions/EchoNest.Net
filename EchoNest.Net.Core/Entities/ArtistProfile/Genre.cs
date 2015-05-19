using Newtonsoft.Json;

namespace EchoNest.Net.Core.Entities.ArtistProfile
{

    public class Genre
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("similarity")]
        public double Similarity { get; set; }

        [JsonProperty("urls")]
        public Urls Urls { get; set; }
    }

}
