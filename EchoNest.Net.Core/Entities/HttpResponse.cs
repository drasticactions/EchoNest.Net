using EchoNest.Net.Core.Entities.ArtistProfile;
using Newtonsoft.Json;

namespace EchoNest.Net.Core.Entities
{

    public class EchoNestHttpResponse
    {

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("artist")]
        public Artist Artist { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("biographies")]
        public Biography[] Biographies { get; set; }

        [JsonProperty("images")]
        public Image[] Images { get; set; }

        [JsonProperty("video")]
        public Video[] Videos { get; set; }

        [JsonProperty("terms")]
        public Term[] Terms { get; set; }

        [JsonProperty("artists")]
        public Artist[] Artists { get; set; }

        [JsonProperty("songs")]
        public Song[] Songs { get; set; }


        [JsonProperty("genres")]
        public Genre[] Genres { get; set; }
    }

}
