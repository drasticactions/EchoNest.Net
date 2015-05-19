using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EchoNest.Net.Core.Managers;
using EchoNest.Net.UAP.Common;
using EchoNest.Net.UAP.Tools.Queries;

namespace EchoNest.Net.UAP.ViewModels
{
    public class ArtistListPageViewModel : NotifierBase
    {
        public ArtistManager ArtistManager { get; set; } = new ArtistManager(Locator.ViewModels.MainPageVm.ApiKey);
        public ArtistOnSuggestedQuery ArtistOnSuggestedQuery { get; set; } = new ArtistOnSuggestedQuery();

        public ArtistOnChangedQuery ArtistOnChangedQuery { get; set; } = new ArtistOnChangedQuery();

        public ArtistOnSubmittedQuery ArtistOnSubmittedQuery { get; set; } = new ArtistOnSubmittedQuery();

        public ArtistOnItemClick ArtistOnItemClick { get; set; } = new ArtistOnItemClick();
    }
}
