using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.DTOs
{
    public class ProjectTaskUpdateDTO
    {
        public int TaskId { get; set; }
        public string Description { get; set; }
        public DateTime DeadlineDate { get; set; }
    }
}
