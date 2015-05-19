using System;
using System.Threading.Tasks;
using EchoNest.Net.Core.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EchoNest.Net.UnitTests
{
    [TestClass]
    public class ArtistManagerTest
    {
        private static readonly ArtistManager ArtistManager = new ArtistManager("FILDTEOIK2HBORODV");
        // The API Key used here is the sample provided by EchoNest, and probably
        // won't work for you. You'll need to get your own key at 
        // http://developer.echonest.com/docs/v4/index.html

        [TestMethod]
        public async Task When_Getting_An_Artists_Custom_Profile()
        {
            var bucket = new[] { "hotttnesss", "images" };
            var result = await ArtistManager.GetCustomProfileAsync("ARH6W4X1187B99274F", bucket);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task When_Getting_An_Artists_Profile_Doc_Count()
        {
            var result = await ArtistManager.GetProfileDocCountsAsync("ARH6W4X1187B99274F");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task When_Getting_An_Artists_Profile_Genre()
        {
            var result = await ArtistManager.GetProfileGenreAsync("ARH6W4X1187B99274F");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task When_Getting_An_Artists_Profile_Bio()
        {
            var result = await ArtistManager.GetProfileBioAsync("ARH6W4X1187B99274F");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task When_Getting_An_Artists_Profile_News()
        {
            var result = await ArtistManager.GetProfileNewsAsync("ARH6W4X1187B99274F");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task When_Getting_An_Artists_Profile_Blogs()
        {
            var result = await ArtistManager.GetProfileBlogsAsync("ARH6W4X1187B99274F");
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public async Task When_Getting_An_Artists_Profile_Familiarity()
        {
            var result = await ArtistManager.GetProfileFamiliarityAsync("ARH6W4X1187B99274F");
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public async Task When_Getting_An_Artists_Profile_Images()
        {
            var result = await ArtistManager.GetProfileImagesAsync("ARH6W4X1187B99274F");
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public async Task When_Getting_An_Artists_Profile_Location()
        {
            var result = await ArtistManager.GetProfileLocationAsync("ARH6W4X1187B99274F");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task When_Getting_An_Artists_Profile_Reviews()
        {
            var result = await ArtistManager.GetProfileReviewsAsync("ARH6W4X1187B99274F");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task When_Getting_An_Artists_Profile_Songs()
        {
            var result = await ArtistManager.GetProfileSongsAsync("ARH6W4X1187B99274F");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task When_Getting_An_Artists_Profile_Terms()
        {
            var result = await ArtistManager.GetProfileTermsAsync("ARH6W4X1187B99274F");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task When_Getting_An_Artists_Profile_Urls()
        {
            var result = await ArtistManager.GetProfileUrlsAsync("ARH6W4X1187B99274F");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task When_Getting_An_Artists_Profile_Videos()
        {
            var result = await ArtistManager.GetProfileVideoAsync("ARH6W4X1187B99274F");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task When_Getting_An_Artists_Profile_Years_Active()
        {
            var result = await ArtistManager.GetProfileYearsActiveAsync("ARH6W4X1187B99274F");
            Assert.IsNotNull(result);
        }
    }
}
