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
        Task<IEnumerable<ProjectDTO>> GetAll();
    }
}
