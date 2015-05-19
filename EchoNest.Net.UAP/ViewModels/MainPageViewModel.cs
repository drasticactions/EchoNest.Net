using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EchoNest.Net.UAP.Commands.Navigation;
using EchoNest.Net.UAP.Common;
using EchoNest.Net.UAP.Models;

namespace EchoNest.Net.UAP.ViewModels
{
    public class MainPageViewModel : NotifierBase
    {
        public string ApiKey { get; set; }

        public List<MenuItem> MenuItems { get; set; }

        public MainPageViewModel()
        {
            MenuItems = new List<MenuItem>()
            {
                new MenuItem()
                {
                    Icon = "\uE7F8",
                    Name = "Artists",
                    Command = new NavigateToArtistListPage()
                }
            };
        }
    }
}
