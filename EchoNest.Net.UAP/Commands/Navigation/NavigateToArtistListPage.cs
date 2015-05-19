using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EchoNest.Net.UAP.Common;
using EchoNest.Net.UAP.Pages.Artists;

namespace EchoNest.Net.UAP.Commands.Navigation
{
    public class NavigateToArtistListPage : AlwaysExecutableCommand
    {
        public override void Execute(object parameter)
        {
            App.RootFrame.Navigate(typeof (ArtistListPage));
        }
    }
}
