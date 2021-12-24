using Microsoft.AspNetCore.Components.Authorization;
using PMS.APIFramework.ApiResponseContent;
using PMS.BlazorWASMClient.Utility.DTOs;
using PMS.BlazorWASMClient.Utility.Extensions;
using PMS.BlazorWASMClient.Utility.Notifications;
using PMS.BlazorWASMClient.Utility.StateProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.Services.Implementations
{
    public class NotificationService : INotificationService
    {
        private readonly HttpClient _httpClient;
        private readonly CustomAuthenticationStateProvider _authenticationStateProvider;

        public NotificationService(HttpClient httpClient, AuthenticationStateProvider authenticationStateProvider)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = (CustomAuthenticationStateProvider)authenticationStateProvider;
        }

        public async Task<IEnumerable<ClientNotification>> GetAll(bool justUnread = true)
        {
            var notifications = new List<ClientNotification>();
            var serverNotifications = await GetAllFromServer();

            if (serverNotifications.IsSuccess && serverNotifications.Data.Count() > 0)
            {
                notifications = ClientNotificationFactory.GenerateNotifications(serverNotifications.Data.ToList()).ToList();
            }

            return notifications;
        }

        public async Task<ApiResult> MarkAsRead(params int[] notificationIds)
        {
            var idList = new IdsDTO { IdList=notificationIds.ToList() };

            var response = await _httpClient.CustomPost(_authenticationStateProvider, "api/notification/MarkAsRead", idList);

            return response;
        }

        private async Task<ApiResult<IEnumerable<NotificationDTO>>> GetAllFromServer(bool justUnread = true)
        {
            var response = await _httpClient.CustomGet<IEnumerable<NotificationDTO>>(_authenticationStateProvider, "api/notification/GetUnreadNotifications");

            return response;
        }
    }
}
