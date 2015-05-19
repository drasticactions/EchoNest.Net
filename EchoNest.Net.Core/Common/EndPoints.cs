using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoNest.Net.Core.Common
{
    public class EndPoints
    {
        private const string BaseUrl = "http://developer.echonest.com/api/v4/";

        #region Artist

        #region Profile

        public const string ArtistProfileDocCounts =
            BaseUrl + "artist/profile?api_key={0}&id={1}&format=json&bucket=doc_counts";

        public const string ArtistProfileGenre = 
            BaseUrl + "artist/profile?api_key={0}&id={1}&format=json&bucket=genre";

        public const string ArtistProfileBlogs = 
            BaseUrl + "artist/profile?api_key={0}&id={1}&format=json&bucket=blogs";

        public const string ArtistProfileDiscovery =
            BaseUrl + "artist/profile?api_key={0}&id={1}&format=json&bucket=discovery&bucket=discovery_rank";

        public const string ArtistProfileFamiliarity =
            BaseUrl + "artist/profile?api_key={0}&id={1}&format=json&bucket=familiarity&bucket=familiarity_rank";

        public const string ArtistProfileHotttnesss =
            BaseUrl + "artist/profile?api_key={0}&id={1}&format=json&bucket=hotttnesss&bucket=hotttnesss_rank";

        public const string ArtistProfileImages =
            BaseUrl + "artist/profile?api_key={0}&id={1}&format=json&bucket=images";

        public const string ArtistProfileLocation =
            BaseUrl + "artist/profile?api_key={0}&id={1}&format=json&bucket=artist_location";

        public const string ArtistProfileBiographies =
            BaseUrl + "artist/profile?api_key={0}&id={1}&format=json&bucket=biographies";

        public const string ArtistProfileNews =
            BaseUrl + "artist/profile?api_key={0}&id={1}&format=json&bucket=news";

        public const string ArtistProfileReviews =
            BaseUrl + "artist/profile?api_key={0}&id={1}&format=json&bucket=reviews";

        public const string ArtistProfileSongs =
            BaseUrl + "artist/profile?api_key={0}&id={1}&format=json&bucket=songs";

        public const string ArtistProfileTerms =
            BaseUrl + "artist/profile?api_key={0}&id={1}&format=json&bucket=terms";

        public const string ArtistProfileUrls =
            BaseUrl + "artist/profile?api_key={0}&id={1}&format=json&bucket=urls";

        public const string ArtistProfileVideo =
            BaseUrl + "artist/profile?api_key={0}&id={1}&format=json&bucket=video";

        public const string ArtistProfileYearsActive =
            BaseUrl + "artist/profile?api_key={0}&id={1}&format=json&bucket=years_active";

        public const string ArtistProfileCustom =
            BaseUrl + "artist/profile?api_key={0}&id={1}&format=json{2}";

        #endregion

        public const string ArtistBiographies =
             BaseUrl + "artist/biographies?api_key={0}&id={1}&format=json&results={2}&start={3}&license={4}";

        public const string ArtistBlogs =
             BaseUrl + "artist/blogs?api_key={0}&id={1}&format=json&results={2}&start={3}&high_relevance={4}";

        public const string ArtistImages =
            BaseUrl + "artist/images?api_key={0}&id={1}&format=json&results={2}&start={3}&license={4}";

        public const string ArtistNews =
            BaseUrl + "artist/news?api_key={0}&id={1}&format=json&results={2}&start={3}&high_relevance={4}";

        public const string ArtistSpecificReviews =
            BaseUrl + "artist/news?api_key={0}&id={1}&format=json&results={2}&start={3}";

        public const string ArtistSearch =
            BaseUrl + "artist/search?api_key={0}&format=json&results={1}&start={2}";

        public const string ArtistSongs =
            BaseUrl + "artist/songs?api_key={0}&id={1}&format=json&results={2}&start={3}";

        public const string ArtistSimilar =
            BaseUrl + "artist/similar?api_key={0}&format=json&results={1}&start={2}&min_results={3}";

        public const string ArtistSuggest =
            BaseUrl + "artist/suggest?api_key={0}&format=json&results={1}";

        public const string ArtistExtract =
            BaseUrl + "artist/extract?api_key={0}&format=json&results={1}";

        public const string TopHotttArtist =
            BaseUrl + "artist/top_hottt?api_key={0}&format=json&results={1}&start={2}";

        public const string TopTermsArtist =
            BaseUrl + "artist/top_terms?api_key={0}&format=json&results={1}";

        public const string ArtistTwitter =
            BaseUrl + "artist/twitter?api_key={0}&id={1}&format=json";

        public const string ArtistVideos =
            BaseUrl + "artist/video?api_key={0}&id={1}&format=json&results={2}&start={3}";

        #endregion

        #region Genre

        public const string TopArtistInGenre =
            BaseUrl + "genre/artists?api_key={0}&name={1}&format=json&results={2}&start={3}";

        public const string GenreList =
           BaseUrl + "genre/list?api_key={0}&format=json&results={1}&start={2}";

        public const string GenreProfile =
            BaseUrl + "genre/profile?api_key={0}&format=json&name={1}";

        public const string GenreSearch =
            BaseUrl + "genre/search?api_key={0}&format=json&name={1}&results={2}&start={3}";

        public const string GenreSimilar =
            BaseUrl + "genre/similar?api_key={0}&format=json&name={1}&results={2}&start={3}";
        #endregion

        #region Songs

        public const string SongSearch =
          BaseUrl + "song/search?api_key={0}&format=json&results={1}&start={2}";

        public const string SongProfile =
            BaseUrl + "song/profile?api_key={0}&id={1}&track_id={2}&format=json";
        #endregion

        #region Tracks
        public const string TrackProfile =
            BaseUrl + "track/profile?api_key={0}&format=json";

        public const string TrackPropertiesViaUrl =
            BaseUrl + "track/upload?api_key={0}&url={1}&format=json";

        public const string TrackPropertiesViaFile =
            BaseUrl + "track/upload?api_key={0}&filetype={1}&format=json";

        #endregion

        #region Playlists

        public const string BasicPlaylist =
            BaseUrl + "playlist/basic?api_key={0}&results={1}&format=json";

        public const string StaticPlaylist =
            BaseUrl + "playlist/static?api_key={0}&results={1}&format=json";

        public const string DynamicPlaylistCreate =
            BaseUrl + "playlist/dynamic/create?api_key={0}";

        public const string DynamicPlaylistNext =
            BaseUrl + "playlist/dynamic/next?api_key={0}";

        public const string DynamicPlaylistFeedback =
            BaseUrl + "playlist/dynamic/feedback?api_key={0}";

        public const string DynamicPlaylistInfo =
            BaseUrl + "playlist/dynamic/info?api_key={0}";

        public const string DynamicPlaylistDelete =
            BaseUrl + "playlist/dynamic/delete?api_key={0}";

        public const string DynamicPlaylistSteer =
            BaseUrl + "playlist/dynamic/steer?api_key={0}";

        #endregion

        #region Taste

        public const string TasteCreate =
           BaseUrl + "tasteprofile/create?api_key={0}&type={1}&name={2}";

        public const string TasteUpdate =
            BaseUrl + "tasteprofile/update?api_key={0}&id={1}";

        public const string TasteKeyValues =
            BaseUrl + "tasteprofile/keyvalues?api_key={0}&format=json&id={1}";

        public const string TastePlay =
            BaseUrl + "tasteprofile/play?api_key={0}&format=json";

        public const string TasteSkip =
            BaseUrl + "tasteprofile/skip?api_key={0}&format=json&id={1}";

        public const string TasteFavorite =
            BaseUrl + "tasteprofile/favorite?api_key={0}&format=json&id={1}";

        public const string TasteBan =
            BaseUrl + "tasteprofile/ban?api_key={0}&format=json&id={1}";

        public const string TasteRate =
            BaseUrl + "tasteprofile/rate?api_key={0}&format=json&id={1}";

        public const string TasteProfile =
            BaseUrl + "tasteprofile/profile?api_key={0}&format=json";

        public const string TasteRead =
            BaseUrl + "tasteprofile/read?api_key={0}&format=json&id={1}&results={2}&start={3}";

        public const string TasteFeed =
            BaseUrl + "tasteprofile/feed?api_key={0}&format=json&id={1}&results={2}&start={3}";

        public const string TasteDelete =
            BaseUrl + "tasteprofile/delete?api_key={0}&id={1}";

        public const string TasteList =
            BaseUrl + "tasteprofile/list?api_key={0}&results={1}&start={2}";

        #endregion
    }
}
