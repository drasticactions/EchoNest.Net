using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EchoNest.Net.Core.Common;
using EchoNest.Net.Core.Entities;
using EchoNest.Net.Core.Interfaces;
using EchoNest.Net.Core.Options;
using Newtonsoft.Json;
using Artist = EchoNest.Net.Core.Entities.ArtistProfile.Artist;
using Response = EchoNest.Net.Core.Entities.Response;

namespace EchoNest.Net.Core.Managers
{
    public class ArtistManager
    {
        private readonly IWebManager _webManager;
        public ArtistManager(IWebManager webManager)
        {
            _webManager = webManager;
        }

        public ArtistManager(string authenticationToken)
            : this(new WebManager(authenticationToken))
        {
        }

        public async Task<Artist> GetProfileDocCountsAsync(string id)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistProfileDocCounts, _webManager.ApiKey, id));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse.Artist;
        }

        public async Task<Artist> GetProfileGenreAsync(string id)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistProfileGenre, _webManager.ApiKey, id));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse.Artist;
        }

        public async Task<Artist> GetProfileBioAsync(string id)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistProfileBiographies, _webManager.ApiKey, id));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse.Artist;
        }

        public async Task<Artist> GetProfileNewsAsync(string id)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistProfileNews, _webManager.ApiKey, id));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse.Artist;
        }

        public async Task<Artist> GetProfileBlogsAsync(string id)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistProfileBlogs, _webManager.ApiKey, id));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse.Artist;
        }

        public async Task<Artist> GetProfileDiscoveryAsync(string id)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistProfileDiscovery, _webManager.ApiKey, id));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse.Artist;
        }

        public async Task<Artist> GetProfileFamiliarityAsync(string id)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistProfileFamiliarity, _webManager.ApiKey, id));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse.Artist;
        }

        public async Task<Artist> GetProfileHotttnesssAsync(string id)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistProfileHotttnesss, _webManager.ApiKey, id));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse.Artist;
        }

        public async Task<Artist> GetProfileImagesAsync(string id)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistProfileImages, _webManager.ApiKey, id));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse.Artist;
        }

        public async Task<Artist> GetProfileLocationAsync(string id)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistProfileLocation, _webManager.ApiKey, id));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse.Artist;
        }

        public async Task<Artist> GetProfileReviewsAsync(string id)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistProfileReviews, _webManager.ApiKey, id));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse.Artist;
        }

        public async Task<Artist> GetProfileSongsAsync(string id)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistProfileSongs, _webManager.ApiKey, id));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse.Artist;
        }

        public async Task<Artist> GetProfileTermsAsync(string id)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistProfileTerms, _webManager.ApiKey, id));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse.Artist;
        }

        public async Task<Artist> GetProfileUrlsAsync(string id)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistProfileUrls, _webManager.ApiKey, id));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse.Artist;
        }

        public async Task<Artist> GetProfileVideoAsync(string id)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistProfileVideo, _webManager.ApiKey, id));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse.Artist;
        }

        public async Task<Artist> GetProfileYearsActiveAsync(string id)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistProfileTerms, _webManager.ApiKey, id));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse.Artist;
        }

        public async Task<Artist> GetCustomProfileAsync(string id, string[] customParameters)
        {
            var custom = customParameters.Aggregate(string.Empty, (current, parameter) => current + ("&bucket=" + parameter));
            var uri = new Uri(string.Format(EndPoints.ArtistProfileCustom, _webManager.ApiKey, id, custom));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse.Artist;
        }

        public async Task<EchoNestHttpResponse> GetArtistBiographiesAsync(string id, int results = 10, int start = 0, string license = null)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistBiographies, _webManager.ApiKey, id, results, start, license));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }

        public async Task<EchoNestHttpResponse> GetArtistBlogsAsync(string id, int results = 10, int start = 0, bool highRelevance = false)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistBlogs, _webManager.ApiKey, id, results, start, highRelevance));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }

        public async Task<EchoNestHttpResponse> GetArtistImagesAsync(string id, int results = 10, int start = 0, string license = null)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistImages, _webManager.ApiKey, id, results, start, license));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }

        public async Task<EchoNestHttpResponse> GetArtistNewsAsync(string id, int results = 10, int start = 0, bool highRelevance = false)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistNews, _webManager.ApiKey, id, results, start, highRelevance));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }

        public async Task<EchoNestHttpResponse> GetArtistSpecificReviewsAsync(string id, int results = 10, int start = 0)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistSpecificReviews, _webManager.ApiKey, id, results, start));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }

        public async Task<EchoNestHttpResponse> GetArtistSongsAsync(string id, int results = 10, int start = 0)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistSongs, _webManager.ApiKey, id, results, start));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }

        public async Task<EchoNestHttpResponse> GetTopArtistTermsAsync(int results = 10)
        {
            var uri = new Uri(string.Format(EndPoints.TopTermsArtist, _webManager.ApiKey, results));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }

        public async Task<EchoNestHttpResponse> GetTopHotttArtistAsync(int results = 10, int start = 0)
        {
            var uri = new Uri(string.Format(EndPoints.TopHotttArtist, _webManager.ApiKey, results, start));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }

        public async Task<Artist> GetArtistTwitterAsync(string id)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistTwitter, _webManager.ApiKey, id));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse.Artist;
        }

        public async Task<EchoNestHttpResponse> GetArtistVideosAsync(string id, int results = 10, int start = 0)
        {
            var uri = new Uri(string.Format(EndPoints.ArtistVideos, _webManager.ApiKey, id, results, start));
            var result = await _webManager.GetData(uri);
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }

        public async Task<EchoNestHttpResponse> GetArtistSuggestAsync(string name = null, int results = 10)
        {
            var baseUri = string.Format(EndPoints.ArtistSuggest, _webManager.ApiKey, results);
            if (!string.IsNullOrEmpty(name))
            {
                baseUri += "&name=" + name;
            }
            var result = await _webManager.GetData(new Uri(baseUri));
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }

        public async Task<EchoNestHttpResponse> SearchArtistSimilarAsync(string[] bucketParameters, ArtistSimilar searchOptions,
            int results = 15, int minResults = 15, int start = 0)
        {
            if (results < minResults)
            {
                throw new Exception("Results must be higher than minResults");
            }
            var bucket = bucketParameters?.Aggregate(string.Empty, (current, parameter) => current + ("&bucket=" + parameter));
            if (bucket == null)
            {
                throw new Exception("Need to add bucket parameters");
            }
            var uriBase = string.Format(EndPoints.ArtistSimilar, _webManager.ApiKey, results, start, minResults) + bucket;
            uriBase += "&limit=" + searchOptions.Limit.ToString().ToLower();

            if (searchOptions.Id == null && searchOptions.Name == null)
            {
                throw new Exception("Need to add either id or name field");
            }

            var id = searchOptions.Id?.Aggregate(string.Empty, (current, parameter) => current + ("&id=" + parameter));

            if (!string.IsNullOrEmpty(id))
            {
                uriBase += id;
            }

            var name = searchOptions.Name?.Aggregate(string.Empty, (current, parameter) => current + ("&name=" + parameter));

            if (!string.IsNullOrEmpty(name))
            {
                uriBase += name;
            }

            var seed = searchOptions.SeedCatalog?.Aggregate(string.Empty, (current, parameter) => current + ("&seed_catalog=" + parameter));

            if (!string.IsNullOrEmpty(seed))
            {
                uriBase += seed;
            }

            if (searchOptions.MaxFamiliarity >= 0)
            {
                uriBase += "&max_familiarity=" + searchOptions.MaxFamiliarity;
            }

            if (searchOptions.MinFamiliarity >= 0)
            {
                uriBase += "&min_familiarity=" + searchOptions.MinFamiliarity;
            }

            if (searchOptions.MaxHotttnesss >= 0)
            {
                uriBase += "&max_hotttnesss=" + searchOptions.MaxHotttnesss;
            }

            if (searchOptions.MinFamiliarity >= 0)
            {
                uriBase += "&min_hotttnesss=" + searchOptions.MinFamiliarity;
            }

            if (searchOptions.IsArtistStillActiveSearch)
            {
                uriBase += "&artist_end_year_after=present";
            }
            else if (searchOptions.ArtistEndYearAfter >= 0)
            {
                uriBase += "&artist_end_year_after=" + searchOptions.ArtistEndYearAfter;
            }

            if (searchOptions.IsArtistNotActiveSearch)
            {
                uriBase += "&artist_end_year_before=present";
            }
            else if (searchOptions.ArtistEndYearBefore >= 0)
            {
                uriBase += "&artist_end_year_before=" + searchOptions.ArtistEndYearBefore;
            }

            if (searchOptions.ArtistStartYearAfter >= 0)
            {
                uriBase += "&artist_start_year_after=" + searchOptions.ArtistStartYearAfter;
            }

            if (searchOptions.ArtistStartYearBefore >= 0)
            {
                uriBase += "&artist_start_year_before=" + searchOptions.ArtistStartYearBefore;
            }

            var result = await _webManager.GetData(new Uri(uriBase));
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }

        public async Task<EchoNestHttpResponse> SearchArtistExtractAsync(string[] bucketParameters, ArtistExtract searchOptions,
            int results = 10)
        {
            var bucket = bucketParameters?.Aggregate(string.Empty, (current, parameter) => current + ("&bucket=" + parameter));
            if (bucket == null)
            {
                throw new Exception("Need to add bucket parameters");
            }
            var uriBase = string.Format(EndPoints.ArtistExtract, _webManager.ApiKey, results) + bucket;
            uriBase += "&limit=" + searchOptions.Limit.ToString().ToLower();

            if (!string.IsNullOrEmpty(searchOptions.Text))
            {
                uriBase += "&text=" + searchOptions.Text;
            }

            if (searchOptions.MaxFamiliarity >= 0)
            {
                uriBase += "&max_familiarity=" + searchOptions.MaxFamiliarity;
            }

            if (searchOptions.MinFamiliarity >= 0)
            {
                uriBase += "&min_familiarity=" + searchOptions.MinFamiliarity;
            }

            if (searchOptions.MaxHotttnesss >= 0)
            {
                uriBase += "&max_hotttnesss=" + searchOptions.MaxHotttnesss;
            }

            if (searchOptions.MinFamiliarity >= 0)
            {
                uriBase += "&min_hotttnesss=" + searchOptions.MinFamiliarity;
            }

            if (!string.IsNullOrEmpty(searchOptions.Sort))
            {
                uriBase += "&sort=" + searchOptions.Sort;
            }

            var result = await _webManager.GetData(new Uri(uriBase));
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }



        public async Task<EchoNestHttpResponse> SearchArtistsAsync(string[] bucketParameters, ArtistSearch searchOptions, int results = 10, int start = 0)
        {
            var bucket = bucketParameters?.Aggregate(string.Empty, (current, parameter) => current + ("&bucket=" + parameter));
            if (bucket == null)
            {
                throw new Exception("Need to add bucket parameters");
            }
            var uriBase = string.Format(EndPoints.ArtistSearch, _webManager.ApiKey, results, start) + bucket;
            uriBase += "&limit=" + searchOptions.Limit.ToString().ToLower();

            if (!string.IsNullOrEmpty(searchOptions.ArtistLocation))
            {
                uriBase += "&artist_location=" + searchOptions.ArtistLocation;
            }

            if (!string.IsNullOrEmpty(searchOptions.Name))
            {
                uriBase += "&name=" + searchOptions.Name;
            }

            var description = searchOptions.Description?.Aggregate(string.Empty, (current, parameter) => current + ("&description=" + parameter));

            if (!string.IsNullOrEmpty(description))
            {
                uriBase += description;
            }

            var genre = searchOptions.Genre?.Aggregate(string.Empty, (current, parameter) => current + ("&genre=" + parameter));

            if (!string.IsNullOrEmpty(genre))
            {
                uriBase += genre;
            }

            var mood = searchOptions.Mood?.Aggregate(string.Empty, (current, parameter) => current + ("&mood=" + parameter));

            if (!string.IsNullOrEmpty(mood))
            {
                uriBase += mood;
            }

            if (!string.IsNullOrEmpty(searchOptions.RankType))
            {
                uriBase += "&rank_type=" + searchOptions.RankType;
            }

            uriBase += "&fuzzy_match=" + searchOptions.FuzzyMatch.ToString().ToLower();

            if (searchOptions.MaxFamiliarity >= 0)
            {
                uriBase += "&max_familiarity=" + searchOptions.MaxFamiliarity;
            }

            if (searchOptions.MinFamiliarity >= 0)
            {
                uriBase += "&min_familiarity=" + searchOptions.MinFamiliarity;
            }

            if (searchOptions.MaxHotttnesss >= 0)
            {
                uriBase += "&max_hotttnesss=" + searchOptions.MaxHotttnesss;
            }

            if (searchOptions.MinFamiliarity >= 0)
            {
                uriBase += "&min_hotttnesss=" + searchOptions.MinFamiliarity;
            }

            if (searchOptions.IsArtistStillActiveSearch)
            {
                uriBase += "&artist_end_year_after=present";
            }
            else if (searchOptions.ArtistEndYearAfter >= 0)
            {
                uriBase += "&artist_end_year_after=" + searchOptions.ArtistEndYearAfter;
            }

            if (searchOptions.IsArtistNotActiveSearch)
            {
                uriBase += "&artist_end_year_before=present";
            }
            else if (searchOptions.ArtistEndYearBefore >= 0)
            {
                uriBase += "&artist_end_year_before=" + searchOptions.ArtistEndYearBefore;
            }

            if (searchOptions.ArtistStartYearAfter >= 0)
            {
                uriBase += "&artist_start_year_after=" + searchOptions.ArtistStartYearAfter;
            }

            if (searchOptions.ArtistStartYearBefore >= 0)
            {
                uriBase += "&artist_start_year_before=" + searchOptions.ArtistStartYearBefore;
            }

            if (!string.IsNullOrEmpty(searchOptions.Sort))
            {
                uriBase += "&sort=" + searchOptions.Sort;
            }

            var result = await _webManager.GetData(new Uri(uriBase));
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }
    }
}
