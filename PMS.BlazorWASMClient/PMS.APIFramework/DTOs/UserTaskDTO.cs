﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.DTOs
{
    public class UserTaskDTO
    {
        public int UserId { get; set; }
        public int TaskId { get; set; }
        public int RegisterUserId { get; set; }
    }
}
