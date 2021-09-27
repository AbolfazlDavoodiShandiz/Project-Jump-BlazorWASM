using PMS.APIFramework.ApiResponseContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.Services.Implementations
{
    public class ApiTestService : IApiTestService
    {
        private readonly HttpClient _httpClient;

        public ApiTestService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> ApiTestInfo()
        {
            var response = await _httpClient.GetFromJsonAsync<ApiResult<string>>("api/API/Info");

            return response.Data;
        }
    }
}
