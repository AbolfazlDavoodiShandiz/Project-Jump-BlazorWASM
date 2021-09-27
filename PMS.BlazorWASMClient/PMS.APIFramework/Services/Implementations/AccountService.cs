using Newtonsoft.Json;
using PMS.APIFramework.ApiResponseContent;
using PMS.BlazorWASMClient.Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Blazored.LocalStorage;

namespace PMS.BlazorWASMClient.Utility.Services.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;

        public AccountService(HttpClient httpClient,ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService;
        }

        public async Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO)
        {
            var response = await _httpClient.PostAsJsonAsync("api/account/userlogin", loginRequestDTO);
            var responseContent = await response.Content.ReadAsStringAsync();
            var apiResponseContent = JsonConvert.DeserializeObject<ApiResult<LoginResponseDTO>>(responseContent);

            LoginResponseDTO loginResponseDTO = new LoginResponseDTO();

            if (apiResponseContent.IsSuccess)
            {
                loginResponseDTO = apiResponseContent.Data;
                await _localStorageService.SetItemAsync("user_account", loginResponseDTO);
            }

            return loginResponseDTO;
        }
    }
}
