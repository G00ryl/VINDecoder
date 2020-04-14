using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VIN.Http;

namespace VIN.Services
{
    public class VinService : IVinService
    {
        private readonly VinHttpClient _vinHttpClient;

        public VinService(VinHttpClient vinHttpClient)
        {
            _vinHttpClient = vinHttpClient;
        }

        public async Task<Models.VIN> GetAsync(string vin)
        {
            var requestUri = $"?vin={vin}";
            var response = await _vinHttpClient.GetAsync(requestUri);

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Models.VIN>(responseString);
        }
    }
}
