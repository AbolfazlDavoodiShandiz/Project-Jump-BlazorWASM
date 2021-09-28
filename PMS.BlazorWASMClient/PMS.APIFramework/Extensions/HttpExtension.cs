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

namespace PMS.BlazorWASMClient.Utility.Extensions
{
    public static class HttpExtension
    {
        public static async Task<string> CustomPost(this HttpClient httpClient,string apiAdress,object data)
        {
            var response = await httpClient.PostAsJsonAsync(apiAdress, data);
            var responseContent = await response.Content.ReadAsStringAsync();

            return responseContent;
        }
    }
}
