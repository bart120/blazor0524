using ServicesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLibrary.Services
{
    public class CarsService
    {
        private readonly HttpClient _httpClient;

        public CarsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Car>> GetCarsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Car>>("cars");
        }

        public async Task<Car> GetCarByIDAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Car>($"cars/{id}");
        }

        public async Task<Car> DeleteCarAsync(int id)
        {
            return await _httpClient.DeleteFromJsonAsync<Car>($"cars/{id}");
        }

        public async Task<Car?> CreateCarAsync(Car car)
        {
            var resp = await _httpClient.PostAsJsonAsync<Car>("cars", car);
            if (resp.IsSuccessStatusCode)
            {
                return await resp.Content.ReadFromJsonAsync<Car>();
            }
            else
                return null;
        }


    }
}
