using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EchoNest.Net.Core.Managers;

namespace EchoNest.Net.Core.Interfaces
{
    public interface IWebManager
    {
        bool IsNetworkAvailable { get; }

        string ApiKey { get; set; }
        Task<WebManager.Result> PostData(Uri uri, MultipartContent header, StringContent content);

        Task<WebManager.Result> PutData(Uri uri, StringContent json);

        Task<WebManager.Result> DeleteData(Uri uri, StringContent json);

        Task<WebManager.Result> GetData(Uri uri);
    }
}
