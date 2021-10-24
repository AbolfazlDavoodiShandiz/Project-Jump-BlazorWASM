using PMS.APIFramework.ApiResponseContent;
using PMS.BlazorWASMClient.Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.Services
{
    public interface IAccountService
    {
        Task<ApiResult> Register(UserRegistrationDTO userRegistrationDTO);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task Logout();
        Task<ApiResult<IEnumerable<UserSearchResponseDTO>>> SearchUser(string searchText);
    }
}
