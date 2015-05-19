using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml.Data;
using EchoNest.Net.Core.Entities.ArtistProfile;
using EchoNest.Net.Core.Managers;
using EchoNest.Net.Core.Options;

namespace EchoNest.Net.UAP.ScrollingCollection.Artists
{
    public class ArtistListScrollingCollection : ObservableCollection<Artist>, ISupportIncrementalLoading, INotifyPropertyChanged
    {
        public ArtistListScrollingCollection(string[] bucketParameters, ArtistSearch search)
        {
            Start = 0;
            TotalResults = 0;
            IsLoading = false;
            HasMoreItems = true;
            SearchOptions = search;
            BucketParameters = bucketParameters;
        }


        public IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync(uint count)
        {
            return LoadDataAsync(count).AsAsyncOperation();
        }

        public async Task<LoadMoreItemsResult> LoadDataAsync(uint count)
        {
            IsLoading = true;
            var result = await ArtistManager.SearchArtistsAsync(BucketParameters, SearchOptions, 10, Start);
            foreach (var artist in result.Artists)
            {
                Add(artist);
            }
            HasMoreItems = result.Artists.Length > 0;
            TotalResults = result.Total;
            Start += result.Artists.Length;
            IsLoading = false;
            return new LoadMoreItemsResult { Count = count };
        }

        private string[] BucketParameters { get; set; }

        private ArtistManager ArtistManager { get; set; } = new ArtistManager(Locator.ViewModels.MainPageVm.ApiKey);

        private ArtistSearch SearchOptions { get; set; }

        private int TotalResults { get; set; }

        private int Start { get; set; }

        private bool _isLoading;
        public bool IsLoading
        {
            get { return _isLoading; }

            private set
            {
                _isLoading = value;
                OnPropertyChanged(new PropertyChangedEventArgs("IsLoading"));
            }
        }


        public bool HasMoreItems { get; private set; }
    }
}
