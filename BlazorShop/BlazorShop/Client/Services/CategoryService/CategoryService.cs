﻿using BlazorShop.Client.Shared;

namespace BlazorShop.Client.Services.CategoryService
{
    public class CategoryService : ICatergoryService
    {
        private readonly HttpClient _http;

        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public List<Category> Categories { get; set; }

        public async Task GetCategories()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Category");
            if (response != null && response.Data != null)
            {
                Categories = response.Data;
            }
        }
    }
}
