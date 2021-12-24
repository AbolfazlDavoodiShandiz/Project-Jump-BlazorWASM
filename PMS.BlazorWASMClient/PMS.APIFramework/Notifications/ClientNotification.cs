using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.Notifications
{
    public class ClientNotification
    {
        public int NotificationId { get; set; }
        public string FromUsername { get; set; }
        public DateTime CreateDate { get; set; }
        public string NotificationText { get; set; }
        public bool IsRead { get; set; }
    }
}
