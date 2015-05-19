using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Autofac;
using EchoNest.Net.UAP.Common;
using EchoNest.Net.UAP.ViewModels;

namespace EchoNest.Net.UAP.Locator
{
    public class ViewModels
    {
        public ViewModels()
        {
            if (DesignMode.DesignModeEnabled)
            {
                App.Container = AutoFacConfiguration.Configure();
            }
        }
        public static MainPageViewModel MainPageVm => App.Container.Resolve<MainPageViewModel>();
        public static ArtistListPageViewModel ArtistListPageVm => App.Container.Resolve<ArtistListPageViewModel>();
    }
}
