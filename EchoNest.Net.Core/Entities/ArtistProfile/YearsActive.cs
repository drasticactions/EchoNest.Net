using Newtonsoft.Json;

namespace EchoNest.Net.Core.Entities.ArtistProfile
{

    public class YearsActive
    {

        [JsonProperty("start")]
        public int Start { get; set; }
    }

}
