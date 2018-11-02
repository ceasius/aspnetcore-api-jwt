﻿using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Starter.API.IntegrationTests.Controllers.Resources
{
    public static class HttpClientExtensions
    {
        public static async Task<T> ReadAsJsonAsync<T>(this HttpContent content)
        {
            var dataAsString = await content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(dataAsString);
        }
    }
}
