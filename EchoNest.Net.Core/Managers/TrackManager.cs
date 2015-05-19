using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using EchoNest.Net.Core.Common;
using EchoNest.Net.Core.Entities;
using EchoNest.Net.Core.Interfaces;
using EchoNest.Net.Core.Options;
using Newtonsoft.Json;

namespace EchoNest.Net.Core.Managers
{
    public class TrackManager
    {
        private readonly IWebManager _webManager;
        public TrackManager(IWebManager webManager)
        {
            _webManager = webManager;
        }

        public TrackManager(string authenticationToken)
            : this(new WebManager(authenticationToken))
        {
        }

        public async Task<EchoNestHttpResponse> GetTrackProfileAsync(string[] bucketParameters, string id = null, string md5 = null)
        {
            if(string.IsNullOrEmpty(id) && string.IsNullOrEmpty(md5))
            {
                throw new Exception("Must have id or md5 set!");
            }

            var bucket = bucketParameters?.Aggregate(string.Empty, (current, parameter) => current + ("&bucket=" + parameter));
            if (bucket == null)
            {
                throw new Exception("Need to add bucket parameters");
            }

            var uriBase = string.Format(EndPoints.TrackProfile, _webManager.ApiKey) + bucket;
            if (!string.IsNullOrEmpty(id))
            {
                uriBase += "&id=" + id;
            }

            if (!string.IsNullOrEmpty(md5))
            {
                uriBase += "&md5=" + md5;
            }

            var result = await _webManager.GetData(new Uri(uriBase));
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }

        public async Task<EchoNestHttpResponse> GetTrackPropertiesViaUrlAsync(string url)
        {
            var result = await _webManager.GetData(new Uri(string.Format(EndPoints.TrackPropertiesViaUrl, _webManager.ApiKey, url)));
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }

        public async Task<EchoNestHttpResponse> GetTrackPropertiesViaFileAsync(Stream fileStream, string filetype)
        {
            var baseUri = new Uri(string.Format(EndPoints.TrackPropertiesViaUrl, _webManager.ApiKey, filetype));
            StreamContent t;
            try
            {
                t = new StreamContent(fileStream);
                t.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                t.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
                t.Headers.Add("Content-Description", "music-data-0");
                t.Headers.Add("Content-Transfer-Encoding", "binary");
                t.Headers.ContentLength = fileStream.Length;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to send file", ex);
            }

            try
            {
                var form = new MultipartContent("mixed", "acebdf13572468") { t };
                var result = await _webManager.PostData(baseUri, form, null);
                var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
                return response.EchoNestHttpResponse;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to send file", ex);
            }
        }
    }
}
