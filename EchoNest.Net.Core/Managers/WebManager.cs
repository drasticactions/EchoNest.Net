using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using EchoNest.Net.Core.Interfaces;

namespace EchoNest.Net.Core.Managers
{
    public class WebManager : IWebManager
    {
        public WebManager(string authToken = null)
        {
            ApiKey = authToken;
        }

        public class Result
        {
            public Result(bool isSuccess, string json)
            {
                IsSuccess = isSuccess;
                ResultJson = json;
            }

            public bool IsSuccess { get; private set; }
            public string ResultJson { get; private set; }
        }

        public string ApiKey { get; set; }

        public bool IsNetworkAvailable => NetworkInterface.GetIsNetworkAvailable();

        public async Task<Result> PostData(Uri uri, MultipartContent header, StringContent content)
        {
            if (ApiKey == null)
            {
                throw new Exception("ApiKey not set");
            }

            using (var httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response;
                    if (header == null)
                    {
                        if (content == null) content = new StringContent(string.Empty);
                        response = await httpClient.PostAsync(uri, content);
                    }
                    else
                    {
                        response = await httpClient.PostAsync(uri, header);
                    }
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return new Result(response.IsSuccessStatusCode, responseContent);
                }
                catch (Exception ex)
                {
                    throw new WebException("Echo Nest API Error: Service error", ex);
                }
            }
        }

        public Task<Result> PutData(Uri uri, StringContent json)
        {
            if (ApiKey == null)
            {
                throw new Exception("ApiKey not set");
            }

            throw new NotImplementedException();
        }

        public Task<Result> DeleteData(Uri uri, StringContent json)
        {
            if (ApiKey == null)
            {
                throw new Exception("ApiKey not set");
            }

            throw new NotImplementedException();
        }

        public async Task<Result> GetData(Uri uri)
        {
            if (ApiKey == null)
            {
                throw new Exception("ApiKey not set");
            }
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync(uri);
                    if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        throw new WebException("Echo Nest API Error: Service not found.");
                    }
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return string.IsNullOrEmpty(responseContent) ? new Result(response.IsSuccessStatusCode, string.Empty) : new Result(response.IsSuccessStatusCode, responseContent);
                }
                catch (Exception ex)
                {

                    throw new WebException("Echo Nest API Error: Service error", ex);
                }
            }
        }
    }
}
