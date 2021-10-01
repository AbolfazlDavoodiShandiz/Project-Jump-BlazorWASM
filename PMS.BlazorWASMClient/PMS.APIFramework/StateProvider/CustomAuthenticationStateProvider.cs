using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Newtonsoft.Json;
using PMS.BlazorWASMClient.Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.StateProvider
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly HttpClient _httpClient;

        public CustomAuthenticationStateProvider(ILocalStorageService localStorageService, HttpClient httpClient)
        {
            _localStorageService = localStorageService;
            _httpClient = httpClient;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var storageAccountData = await _localStorageService.GetItemAsStringAsync("user_account");

            if (!string.IsNullOrWhiteSpace(storageAccountData))
            {
                var accountData = JsonConvert.DeserializeObject<LoginResponseDTO>(storageAccountData);

                if (accountData.UserClaims is not null)
                {
                    var userClaims = new List<Claim>();
                    //convert claim dictionary to list
                    userClaims = accountData.UserClaims.Select(x => new Claim(x.Key, x.Value.ToString())).ToList();

                    var claimsIdentity = new ClaimsIdentity(userClaims, "JWT");
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    var authenticationState = new AuthenticationState(claimsPrincipal);

                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", accountData.Token);

                    return authenticationState;
                }
            }

            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }

        public void NotifyUserLoggedIn(List<Claim> claims)
        {
            var claimsIdentity = new ClaimsIdentity(claims, "JWT");
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            var authenticationState = new AuthenticationState(claimsPrincipal);

            var task = Task.FromResult(new AuthenticationState(claimsPrincipal));

            base.NotifyAuthenticationStateChanged(task);
        }

        public async Task NotifyUserLoggedOut()
        {
            await _localStorageService.RemoveItemAsync("user_account");
            _httpClient.DefaultRequestHeaders.Authorization = null;

            var task = Task.FromResult(new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())));

            base.NotifyAuthenticationStateChanged(task);
        }
    }
}
