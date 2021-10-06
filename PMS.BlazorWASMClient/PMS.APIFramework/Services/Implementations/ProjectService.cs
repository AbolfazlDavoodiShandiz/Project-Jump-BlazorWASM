using Microsoft.AspNetCore.Components.Authorization;
using PMS.APIFramework.ApiResponseContent;
using PMS.BlazorWASMClient.Utility.DTOs;
using PMS.BlazorWASMClient.Utility.Extensions;
using PMS.BlazorWASMClient.Utility.StateProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly HttpClient _httpClient;
        private readonly CustomAuthenticationStateProvider _authenticationStateProvider;

        public ProjectService(HttpClient httpClient, AuthenticationStateProvider authenticationStateProvider)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = (CustomAuthenticationStateProvider)authenticationStateProvider;
        }

        public async Task<ApiResult> CreateProject(ProjectRegisterDTO projectRegisterDTO)
        {
            var response = await _httpClient.CustomPost<ApiResult>(_authenticationStateProvider, "api/Project/CreateProject", projectRegisterDTO);

            return response;
        }

        public async Task<ApiResult<IEnumerable<ProjectDTO>>> GetAll()
        {
            var response = await _httpClient.CustomGet<IEnumerable<ProjectDTO>>(_authenticationStateProvider, "api/Project/UserCreatedProjectList");

            return response;
        }
    }
}
