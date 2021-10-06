using PMS.APIFramework.ApiResponseContent;
using PMS.BlazorWASMClient.Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.Services
{
    public interface IProjectService
    {
        Task<ApiResult<IEnumerable<ProjectDTO>>> GetAll();
        Task<ApiResult> CreateProject(ProjectRegisterDTO projectRegisterDTO);
        Task<ApiResult> UpdateProject(ProjectUpdateDTO projectUpdateDTO);
        Task<ApiResult> DeleteProject(int id);
    }
}
