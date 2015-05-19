using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EchoNest.Net.Core.Entities
{
    public class Response
    {
        [JsonProperty("response")]
        public EchoNestHttpResponse EchoNestHttpResponse { get; set; }
    }
}
