using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EchoNest.Net.Core.Common;
using EchoNest.Net.Core.Entities;
using EchoNest.Net.Core.Interfaces;
using Newtonsoft.Json;

namespace EchoNest.Net.Core.Managers
{
    public class GenreManager
    {
        private readonly IWebManager _webManager;
        public GenreManager(IWebManager webManager)
        {
            _webManager = webManager;
        }

        public GenreManager(string authenticationToken)
            : this(new WebManager(authenticationToken))
        {
        }

        public async Task<EchoNestHttpResponse> GetTopArtistsInGenreAsync(string name, string[] bucketParameters, int results = 10, int start = 0, bool limit = false)
        {
            var bucket = bucketParameters?.Aggregate(string.Empty, (current, parameter) => current + ("&bucket=" + parameter));
            if (bucket == null)
            {
                throw new Exception("Need to add bucket parameters");
            }

            var uriBase = string.Format(EndPoints.TopArtistInGenre, _webManager.ApiKey, name, results, start) + bucket;
            uriBase += "&limit=" + limit.ToString().ToLower();

            var result = await _webManager.GetData(new Uri(uriBase));
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }

        public async Task<EchoNestHttpResponse> GetGenreListAsync(string[] bucketParameters, int results = 10, int start = 0)
        {
            var bucket = bucketParameters?.Aggregate(string.Empty, (current, parameter) => current + ("&bucket=" + parameter));
            if (bucket == null)
            {
                throw new Exception("Need to add bucket parameters");
            }

            var uriBase = string.Format(EndPoints.GenreList, _webManager.ApiKey, results, start) + bucket;

            var result = await _webManager.GetData(new Uri(uriBase));
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }

        public async Task<EchoNestHttpResponse> GetGenreProfileAsync(string name, string[] bucketParameters)
        {
            var bucket = bucketParameters?.Aggregate(string.Empty, (current, parameter) => current + ("&bucket=" + parameter));
            if (bucket == null)
            {
                throw new Exception("Need to add bucket parameters");
            }

            var uriBase = string.Format(EndPoints.GenreProfile, _webManager.ApiKey, name) + bucket;
            var result = await _webManager.GetData(new Uri(uriBase));
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }

        public async Task<EchoNestHttpResponse> SearchGenre(string name, string[] bucketParameters, int results = 100,
            int start = 0)
        {
            var bucket = bucketParameters?.Aggregate(string.Empty, (current, parameter) => current + ("&bucket=" + parameter));
            if (bucket == null)
            {
                throw new Exception("Need to add bucket parameters");
            }

            var uriBase = string.Format(EndPoints.GenreSearch, _webManager.ApiKey, name, results, start) + bucket;
            var result = await _webManager.GetData(new Uri(uriBase));
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }

        public async Task<EchoNestHttpResponse> SearchSimilarGenre(string name, string[] bucketParameters, int results = 100,
    int start = 0)
        {
            var bucket = bucketParameters?.Aggregate(string.Empty, (current, parameter) => current + ("&bucket=" + parameter));
            if (bucket == null)
            {
                throw new Exception("Need to add bucket parameters");
            }

            var uriBase = string.Format(EndPoints.GenreSimilar, _webManager.ApiKey, name, results, start) + bucket;
            var result = await _webManager.GetData(new Uri(uriBase));
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }
    }
}
