using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoNest.Net.Core.Options
{
    public class ArtistExtract
    {
        public bool Limit { get; set; }

        public string Text { get; set; }

        public float MaxFamiliarity { get; set; } = -1;

        public float MinFamiliarity { get; set; } = -1;

        public float MaxHotttnesss { get; set; } = -1;

        public float MinHotttnesss { get; set; } = -1;

        public string Sort { get; set; }
    }
}
