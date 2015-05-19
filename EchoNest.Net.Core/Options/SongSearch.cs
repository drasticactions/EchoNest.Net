using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoNest.Net.Core.Options
{
    public class SongSearch
    {
        public bool Limit { get; set; }
        public string Title { get; set; }

        public string Artist { get; set; }

        public string Combinded { get; set; }

        public string[] Description { get; set; }

        public string[] Style { get; set; }

        public string[] Mood { get; set; }

        public string RankType { get; set; }

        public string ArtistId { get; set; }

        public string[] SongType { get; set; }

        public double MaxTempo { get; set; } = -1;

        public double MinTempo { get; set; } = -1;

        public double MaxDuration { get; set; } = -1;

        public double MinDuration { get; set; } = -1;

        public double MaxLoudness { get; set; } = -1;

        public double MinLoudness { get; set; } = -1;

        public double ArtistMaxFamiliarity { get; set; } = -1;

        public double ArtistMinFamiliarity { get; set; } = -1;

        public int ArtistStartYearBefore { get; set; } = -1;

        public int ArtistStartYearAfter { get; set; } = -1;

        public int ArtistEndYearBefore { get; set; } = -1;

        public int ArtistEndYearAfter { get; set; } = -1;

        public bool IsArtistStillActiveSearch { get; set; }

        public bool IsArtistNotActiveSearch { get; set; }

        public double SongMaxHotttnesss { get; set; } = -1;

        public double SongMinHotttnesss { get; set; } = -1;

        public double ArtistMaxHotttnesss { get; set; } = -1;

        public double ArtistMinHotttnesss { get; set; } = -1;

        public double MinLongitude { get; set; } = -181;

        public double MaxLongitude { get; set; } = -181;

        public double MinLatitude { get; set; } = -91;

        public double MaxLatitude { get; set; } = -91;

        public double MaxDanceability { get; set; } = -1;

        public double MinDanceability { get; set; } = -1;

        public double MaxEnergy { get; set; } = -1;

        public double MinEnergy { get; set; } = -1;

        public double MaxLiveness { get; set; } = -1;

        public double MinLiveness { get; set; } = -1;

        public double MaxSpeechiness { get; set; } = -1;

        public double MinSpeechiness { get; set; } = -1;

        public double MaxAcousticness { get; set; } = -1;

        public double MinAcousticness { get; set; } = -1;

        public string Mode { get; set; }

        public string Key { get; set; }

        public string Sort { get; set; }
    }
}
