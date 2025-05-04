using HotelProject.Shared.Dtos.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HotelProjectMauiApp.Services
{
    public class CategoryService
    {
        private readonly HttpClient _httpClient;

        public CategoryService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7237/");
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoriesAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<ResultCategoryDto>>("https://localhost:7237/api/Category");
            return response ?? new List<ResultCategoryDto>();
        }
        public async Task<bool> CreateCategoryAsync(CreateCategoryDto dto)
        {
            var json = JsonConvert.SerializeObject(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://localhost:7237/api/Category", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateCategoryAsync(UpdateCategoryDto dto)
        {
            var json = JsonConvert.SerializeObject(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("https://localhost:7237/api/Category", content); // endpoint ismine dikkat et
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> DeleteCategoryAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"https://localhost:7237/api/Category/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
