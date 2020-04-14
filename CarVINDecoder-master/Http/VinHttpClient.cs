using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace VIN.Http
{
    public class VinHttpClient : HttpClient
    {
        public VinHttpClient()
        {
            BaseAddress = new Uri($"http://api.carmd.com/v3.0/decode?");
            DefaultRequestHeaders.Add("authorization", "Basic " + "OTIyMTRmNjAtNDE4Yi00NmI0LTlhNmMtNjgwMDc0OTdiZGVi");
            DefaultRequestHeaders.Add("partner-token", "5bc8a1bb6a2244cc8fc46c1e74bdba57");
        }
    }
}
