using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EchoNest.Net.UAP.Common;
using EchoNest.Net.UAP.Pages;

namespace EchoNest.Net.UAP.Commands.Navigation
{
    public class NavigateToMainPage : AlwaysExecutableCommand
    {
        public override void Execute(object parameter)
        {
            App.RootFrame.Navigate(typeof (MainPage));
        }
    }
}
