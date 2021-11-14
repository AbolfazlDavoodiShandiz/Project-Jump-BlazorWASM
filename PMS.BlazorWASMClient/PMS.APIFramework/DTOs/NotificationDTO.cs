﻿using PMS.BlazorWASMClient.Utility.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.DTOs
{
    public class NotificationDTO
    {
        public int Id { get; set; }
        public string CreatedUsername { get; set; }
        public int RecieverUserId { get; set; }
        public NotificationType NotificationType { get; set; }
        public string NotificationTypeName { get; }
        public string RelatedObjectTitle { get; set; }
        public int RelatedObjectId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsRead { get; set; }
    }
}
