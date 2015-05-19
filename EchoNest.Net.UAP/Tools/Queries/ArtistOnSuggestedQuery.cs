using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using EchoNest.Net.Core.Managers;
using EchoNest.Net.UAP.Common;

namespace EchoNest.Net.UAP.Tools.Queries
{
    public class ArtistOnSuggestedQuery : AlwaysExecutableCommand
    {
        public async override void Execute(object parameter)
        {
            var vm = Locator.ViewModels.ArtistListPageVm;
            if (vm.IsLoading)
            {
                return;
            }
            var args = parameter as SearchBoxSuggestionsRequestedEventArgs;

            // If querytext/args is null, return.
            var queryText = args?.QueryText;
            if (string.IsNullOrEmpty(queryText)) return;


            var suggestionCollection = args.Request.SearchSuggestionCollection;

            // In order to append query suggestions async, we must get the deferral of the search request box.
            // Otherwise, we will have threading issues.

            var deferral = args.Request.GetDeferral();

            vm.IsLoading = true;
            var results = await vm.ArtistManager.GetArtistSuggestAsync(queryText);
            foreach (var artist in results.Artists)
            {
                suggestionCollection.AppendQuerySuggestion(artist.Name);
            }
            vm.IsLoading = false;
            deferral.Complete();
        }
    }

    public class ArtistOnSubmittedQuery : AlwaysExecutableCommand
    {
        public override void Execute(object parameter)
        {
            var args = parameter as SearchBoxQuerySubmittedEventArgs;
            if (args == null)
            {
                return;
            }
        }
    }

    public class ArtistOnChangedQuery : AlwaysExecutableCommand
    {
        public override void Execute(object parameter)
        {
            var args = parameter as SearchBoxQueryChangedEventArgs;
            if (args == null)
            {
                return;
            }
        }
    }

    public class ArtistOnItemClick : AlwaysExecutableCommand
    {
        public override void Execute(object parameter)
        {
            var args = parameter as ItemClickEventArgs;
            if (args == null)
            {
                return;
            }
        }
    }
}
