using Newtonsoft.Json;

namespace EchoNest.Net.Core.Entities.ArtistProfile
{
    public class Artist
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("foreign_ids")]
        public ForeignCatalogId[] ForeignIds { get; set; }

        [JsonProperty("genres")]
        public Genre[] Genres { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("doc_counts")]
        public DocCounts DocCounts { get; set; }

        [JsonProperty("blogs")]
        public Blog[] Blogs { get; set; }

        [JsonProperty("biographies")]
        public Biography[] Biographies { get; set; }

        [JsonProperty("discovery")]
        public double Discovery { get; set; }

        [JsonProperty("discovery_rank")]
        public int DiscoveryRank { get; set; }

        [JsonProperty("terms")]
        public Term[] Terms { get; set; }

        [JsonProperty("familiarity")]
        public double Familiarity { get; set; }

        [JsonProperty("hotttnesss")]
        public double Hotttnesss { get; set; }

        [JsonProperty("reviews")]
        public Review[] Reviews { get; set; }

        [JsonProperty("images")]
        public Image[] Images { get; set; }

        [JsonProperty("years_active")]
        public YearsActive[] YearsActive { get; set; }

        [JsonProperty("video")]
        public Video[] Video { get; set; }

        [JsonProperty("urls")]
        public Urls Urls { get; set; }

        [JsonProperty("hotttnesss_rank")]
        public int HotttnesssRank { get; set; }

        [JsonProperty("familiarity_rank")]
        public int FamiliarityRank { get; set; }

        [JsonProperty("news")]
        public News[] News { get; set; }

        [JsonProperty("artist_location")]
        public ArtistLocation ArtistLocation { get; set; }

        [JsonProperty("songs")]
        public Song[] Songs { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }
    }

}
