using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoNest.Net.Core.Options
{
    public class ArtistSimilar
    {
        public string[] Id { get; set; }

        public string[] Name { get; set; }

        public string[] SeedCatalog { get; set; }

        public float MaxFamiliarity { get; set; } = -1;

        public float MinFamiliarity { get; set; } = -1;

        public float MaxHotttnesss { get; set; } = -1;

        public float MinHotttnesss { get; set; } = -1;

        public int ArtistStartYearBefore { get; set; } = -1;

        public int ArtistStartYearAfter { get; set; } = -1;

        public int ArtistEndYearBefore { get; set; } = -1;

        public int ArtistEndYearAfter { get; set; } = -1;

        public bool IsArtistStillActiveSearch { get; set; }

        public bool IsArtistNotActiveSearch { get; set; }

        public bool Limit { get; set; }
    }
}
