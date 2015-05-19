using Newtonsoft.Json;

namespace EchoNest.Net.Core.Entities.ArtistProfile
{

    public class Review
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("date_reviewed")]
        public string DateReviewed { get; set; }

        [JsonProperty("date_found")]
        public string DateFound { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("release")]
        public string Release { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

}
