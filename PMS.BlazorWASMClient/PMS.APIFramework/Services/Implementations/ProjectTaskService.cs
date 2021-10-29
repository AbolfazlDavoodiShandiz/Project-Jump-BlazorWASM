using Microsoft.AspNetCore.Components.Authorization;
using PMS.APIFramework.ApiResponseContent;
using PMS.BlazorWASMClient.Utility.DTOs;
using PMS.BlazorWASMClient.Utility.Extensions;
using PMS.BlazorWASMClient.Utility.StateProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.Services.Implementations
{
    public class ProjectTaskService : IProjectTaskService
    {
        private readonly HttpClient _httpClient;
        private readonly CustomAuthenticationStateProvider _customAuthenticationStateProvider;

        public ProjectTaskService(HttpClient httpClient, AuthenticationStateProvider authenticationStateProvider)
        {
            _httpClient = httpClient;
            _customAuthenticationStateProvider = (CustomAuthenticationStateProvider)authenticationStateProvider;
        }

        public async Task<ApiResult> AssignTask(int taskId, int userId)
        {
            var assignDTO = new ProjectTaskAssignToMemberDTO()
            {
                TaskId = taskId,
                UserId = userId
            };

            var response = await _httpClient.CustomPost(_customAuthenticationStateProvider, "api/projecttask/AssignTaskToProjectMember", assignDTO);

            return response;
        }

        public async Task<ApiResult> CreateProjectTask(ProjectTaskRegisterDTO projectTaskRegisterDTO)
        {
            var response = await _httpClient.CustomPost(_customAuthenticationStateProvider, "api/projecttask/CreateProjectTask", projectTaskRegisterDTO);

            return response;
        }

        public async Task<ApiResult> DeleteProjectTask(int id)
        {
            var idDTO = new IdDTO
            {
                Id = id
            };

            var response = await _httpClient.CustomPost(_customAuthenticationStateProvider, "api/projecttask/DeleteProjectTask", idDTO);

            return response;
        }

        public async Task<ApiResult> MarkAsDone(int id)
        {
            var idDTO = new IdDTO
            {
                Id = id
            };

            var response = await _httpClient.CustomPost(_customAuthenticationStateProvider, "api/projecttask/MarkTaskAsDone", idDTO);

            return response;
        }

        public async Task<ApiResult> UnassignTask(int taskId, int userId)
        {
            var assignDTO = new ProjectTaskAssignToMemberDTO()
            {
                TaskId = taskId,
                UserId = userId
            };

            var response = await _httpClient.CustomPost(_customAuthenticationStateProvider, "api/projecttask/UnassignTask", assignDTO);

            return response;
        }

        public async Task<ApiResult> UpdateProjectTask(ProjectTaskUpdateDTO projectTaskUpdateDTO)
        {
            var response = await _httpClient.CustomPost(_customAuthenticationStateProvider, "api/projecttask/EditProjectTask", projectTaskUpdateDTO);

            return response;
        }
    }
}
