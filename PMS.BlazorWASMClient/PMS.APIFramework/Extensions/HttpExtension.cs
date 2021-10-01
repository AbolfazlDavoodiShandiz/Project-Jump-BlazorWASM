using Newtonsoft.Json;
using PMS.APIFramework.ApiResponseContent;
using PMS.BlazorWASMClient.Utility.DTOs;
using PMS.BlazorWASMClient.Utility.StateProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.Extensions
{
    public static class HttpExtension
    {
        public static async Task<ApiResult> CustomPost(this HttpClient httpClient, CustomAuthenticationStateProvider customAuthenticationStateProvider, string apiAdress,
            object data)
        {
            var response = await httpClient.PostAsJsonAsync(apiAdress, data);
            var responseContent = await response.Content.ReadAsStringAsync();
            var apiResponseContent = JsonConvert.DeserializeObject<ApiResult>(responseContent);

            if (apiResponseContent.HttpStatusCode == HttpStatusCode.Unauthorized)
            {
                await customAuthenticationStateProvider.NotifyUserLoggedOut();
            }

            return apiResponseContent;
        }

        public static async Task<ApiResult<TData>> CustomPost<TData>(this HttpClient httpClient, CustomAuthenticationStateProvider customAuthenticationStateProvider,
            string apiAdress, object data)
        {
            var response = await httpClient.PostAsJsonAsync(apiAdress, data);
            var responseContent = await response.Content.ReadAsStringAsync();
            var apiResponseContent = JsonConvert.DeserializeObject<ApiResult<TData>>(responseContent);

            if (apiResponseContent.HttpStatusCode == HttpStatusCode.Unauthorized)
            {
                await customAuthenticationStateProvider.NotifyUserLoggedOut();
            }

            return apiResponseContent;
        }

        public static async Task<ApiResult<TData>> CustomGet<TData>(this HttpClient httpClient, CustomAuthenticationStateProvider customAuthenticationStateProvider,
            string apiAddress, string requestParameter = null)
        {
            string path = string.IsNullOrWhiteSpace(requestParameter) ? apiAddress : $"{apiAddress}/{requestParameter}";

            var apiResponseContent = await httpClient.GetFromJsonAsync<ApiResult<TData>>(path);

            if (apiResponseContent.HttpStatusCode == HttpStatusCode.Unauthorized)
            {
                await customAuthenticationStateProvider.NotifyUserLoggedOut();
            }

            return apiResponseContent;
        }
    }
}
