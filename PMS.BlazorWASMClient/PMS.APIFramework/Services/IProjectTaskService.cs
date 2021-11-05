using PMS.APIFramework.ApiResponseContent;
using PMS.BlazorWASMClient.Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.Services
{
    public interface IProjectTaskService
    {
        Task<ApiResult> CreateProjectTask(ProjectTaskRegisterDTO projectTaskRegisterDTO);
        Task<ApiResult> UpdateProjectTask(ProjectTaskUpdateDTO projectTaskUpdateDTO);
        Task<ApiResult> DeleteProjectTask(int id);
        Task<ApiResult> MarkAsDone(int id);
        Task<ApiResult> AssignTask(int taskId, int userId);
        Task<ApiResult> UnassignTask(int taskId, int userId);
        Task<ApiResult<IEnumerable<ProjectTaskDTO>>> GetUserTasks();
        Task<ApiResult<IEnumerable<string>>> GetTaskAssignedUsers(int taskId);
    }
}
