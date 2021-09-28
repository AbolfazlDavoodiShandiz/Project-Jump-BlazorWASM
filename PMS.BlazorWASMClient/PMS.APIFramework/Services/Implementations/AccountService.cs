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
using Microsoft.AspNetCore.Components.Authorization;
using PMS.BlazorWASMClient.Utility.StateProvider;
using System.Security.Claims;
using PMS.BlazorWASMClient.Utility.Extensions;

namespace PMS.BlazorWASMClient.Utility.Services.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public AccountService(HttpClient httpClient, ILocalStorageService localStorageService, AuthenticationStateProvider authenticationStateProvider)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService;
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO)
        {
            var responseContent = await _httpClient.CustomPost("api/account/userlogin", loginRequestDTO);
            var apiResponseContent = JsonConvert.DeserializeObject<ApiResult<LoginResponseDTO>>(responseContent);

            LoginResponseDTO loginResponseDTO = new LoginResponseDTO();

            if (apiResponseContent.IsSuccess)
            {
                loginResponseDTO = apiResponseContent.Data;
                await _localStorageService.SetItemAsync("user_account", loginResponseDTO);
                await Task.Delay(100);

                var claims = loginResponseDTO.UserClaims.Select(x => new Claim(x.Key, x.Value.ToString())).ToList();
                ((CustomAuthenticationStateProvider)_authenticationStateProvider).NotifyUserLoggedIn(claims);
            }

            return loginResponseDTO;
        }

        public async Task Logout()
        {
            var storageAccountData = await _localStorageService.GetItemAsStringAsync("user_account");
            var accountData = new LoginResponseDTO();

            if (!string.IsNullOrWhiteSpace(storageAccountData))
            {
                accountData = JsonConvert.DeserializeObject<LoginResponseDTO>(storageAccountData);

                var responseContent = await _httpClient.CustomPost("api/account/userlogout", new UserEmailDTO { Email = accountData.Email });
                var apiResponseContent = JsonConvert.DeserializeObject<ApiResult>(responseContent);

                if (apiResponseContent.IsSuccess)
                {
                    await ((CustomAuthenticationStateProvider)_authenticationStateProvider).NotifyUserLoggedOut();
                }
            }
        }
    }
}
