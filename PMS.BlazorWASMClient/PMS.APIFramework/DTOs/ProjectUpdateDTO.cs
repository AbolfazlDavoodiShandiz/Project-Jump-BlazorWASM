using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.DTOs
{
    public class ProjectUpdateDTO
    {
        public int ProjectId { get; set; }
        public string Description { get; set; }
        public DateTime? DeadlineDate { get; set; }
    }
}
