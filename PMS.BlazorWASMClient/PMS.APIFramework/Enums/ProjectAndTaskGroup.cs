using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.Enums
{
    public enum ProjectAndTaskGroup
    {
        [Display(Name = "All")]
        All = 1,
        [Display(Name = "In Progress")]
        InProgress = 2,
        [Display(Name = "Finished")]
        Finished = 3
    }
}
