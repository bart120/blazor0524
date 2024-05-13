using ServicesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLibrary.Services
{
    public class BrandsService
    {
        private readonly HttpClient _httpClient;

        public BrandsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Brand>> getAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Brand>>("brands");
        }
    }
}
