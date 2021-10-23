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
using System.Net.Http.Headers;

namespace PMS.BlazorWASMClient.Utility.Services.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;
        private readonly CustomAuthenticationStateProvider _authenticationStateProvider;

        public AccountService(HttpClient httpClient, ILocalStorageService localStorageService, AuthenticationStateProvider authenticationStateProvider)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService;
            _authenticationStateProvider = (CustomAuthenticationStateProvider)authenticationStateProvider;
        }

        public async Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO)
        {
            var responseContent = await _httpClient.CustomPost<LoginResponseDTO>(_authenticationStateProvider, "api/Account/UserLogin", loginRequestDTO);

            LoginResponseDTO loginResponseDTO = new LoginResponseDTO();

            if (responseContent.IsSuccess)
            {
                loginResponseDTO = responseContent.Data;
                await _localStorageService.SetItemAsync("user_account", loginResponseDTO);
                await Task.Delay(100);

                var claims = loginResponseDTO.UserClaims.Select(x => new Claim(x.Key, x.Value.ToString())).ToList();

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", loginResponseDTO.Token);

                _authenticationStateProvider.NotifyUserLoggedIn(claims);
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

                var responseContent = await _httpClient.CustomPost(_authenticationStateProvider, "api/Account/UserLogout", new UserEmailDTO { Email = accountData.Email });

                if (responseContent.IsSuccess)
                {
                    _httpClient.DefaultRequestHeaders.Authorization = null;
                    await ((CustomAuthenticationStateProvider)_authenticationStateProvider).NotifyUserLoggedOut();
                }
            }
        }

        public async Task<ApiResult<IEnumerable<UserSearchResponseDTO>>> SearchUser(string searchText)
        {
            var response = await _httpClient.CustomGet<IEnumerable<UserSearchResponseDTO>>(_authenticationStateProvider, $"api/Account/SearchUserByEmail/{searchText}");

            return response;
        }
    }
}
