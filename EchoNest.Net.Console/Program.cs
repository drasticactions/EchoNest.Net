using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EchoNest.Net.Core.Managers;
using EchoNest.Net.Core.Options;

namespace EchoNest.Net.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = MainAsync(args);
            t.Wait();
        }

        static async Task MainAsync(string[] args)
        {
            // Used for quick testing of new API components.
            // The API Key used here is the sample provided by EchoNest, and probably
            // won't work for you. You'll need to get your own key at 
            // http://developer.echonest.com/docs/v4/index.html

            //var artistManager = new ArtistManager("FILDTEOIK2HBORODV");
            //var bucket = new string[] { "hotttnesss" };
            //var search = new ArtistSimilar();
            //search.Id = new string[] { "ARH6W4X1187B99274F" };
            //search.Name = new string[] { "Radiohead" };
            //var result = await artistManager.GetArtistSuggestAsync("ゆず");

            //var genreManager = new GenreManager("FILDTEOIK2HBORODV");
            //var bucket = new string[] { "description", "urls" };
            //var result = await genreManager.SearchSimilarGenre("rock", bucket);

            //var result = await trackManager.GetTrackPropertiesViaFileAsync()
            //System.Console.WriteLine(result);
            System.Console.ReadKey();
        }
    }
}
