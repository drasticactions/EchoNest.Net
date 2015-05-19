using Newtonsoft.Json;

namespace EchoNest.Net.Core.Entities.ArtistProfile
{

    public class ForeignCatalogId
    {

        [JsonProperty("catalog")]
        public string Catalog { get; set; }

        [JsonProperty("foreign_id")]
        public string ForeignId { get; set; }
    }

}
