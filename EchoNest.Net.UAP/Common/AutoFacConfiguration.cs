using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using EchoNest.Net.UAP.ViewModels;

namespace EchoNest.Net.UAP.Common
{
    public class AutoFacConfiguration
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register View Models
            builder.RegisterType<MainPageViewModel>().SingleInstance();
            builder.RegisterType<ArtistListPageViewModel>().SingleInstance();
            return builder.Build();
        }
    }
}
