using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.DTOs
{
    public class ProjectTaskAssignToMemberDTO
    {
        public int UserId { get; set; }
        public int TaskId { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsNew { get; set; }
    }
}
