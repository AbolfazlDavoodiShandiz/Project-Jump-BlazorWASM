using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.DTOs
{
    public class ProjectMemberDeleteDTO
    {
        public string ProjectName { get; set; }
        public string UserEmail { get; set; }
    }
}
