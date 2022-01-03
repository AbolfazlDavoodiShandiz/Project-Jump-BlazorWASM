using PMS.APIFramework.ApiResponseContent;
using PMS.BlazorWASMClient.Utility.DTOs;
using PMS.BlazorWASMClient.Utility.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.Services
{
    public interface INotificationService
    {
        Task<IEnumerable<ClientNotification>> GetAll(bool justUnread = true);
        Task<ApiResult> MarkAsRead(params int[] notificationIds);
        Task<bool> ConnectToNotificationHub();

        IEnumerable<string> ServerNotifications { get; }
        event EventHandler OnNotificationRecieved;
    }
}
