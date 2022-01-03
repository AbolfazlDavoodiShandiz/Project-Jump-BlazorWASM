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
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Configuration;
using Blazored.LocalStorage;
using Newtonsoft.Json;

namespace PMS.BlazorWASMClient.Utility.Services.Implementations
{
    public class NotificationService : INotificationService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider authenticationStateProvider;
        private readonly IConfiguration _configuration;
        private readonly ILocalStorageService _localStorageService;
        private readonly CustomAuthenticationStateProvider _authenticationStateProvider;
        private List<string> _notifications;

        public event EventHandler OnNotificationRecieved;

        public IEnumerable<string> ServerNotifications
        {
            get
            {
                return _notifications;
            }
        }

        public NotificationService(HttpClient httpClient, AuthenticationStateProvider authenticationStateProvider, IConfiguration configuration, ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            this.authenticationStateProvider=authenticationStateProvider;
            _configuration=configuration;
            _localStorageService=localStorageService;
            _authenticationStateProvider = (CustomAuthenticationStateProvider)authenticationStateProvider;

            _notifications=new List<string>();
        }

        public async Task<bool> ConnectToNotificationHub()
        {
            bool isConnected = false;
            string url = $"{_configuration["APIBaseURL"]}/hubs/notificationhub";
            string storedUserData = await _localStorageService.GetItemAsStringAsync("user_account");
            var userData = JsonConvert.DeserializeObject<LoginResponseDTO>(storedUserData);

            if (!string.IsNullOrEmpty(userData.Token))
            {
                HubConnection hubConnection = new HubConnectionBuilder()
                    .WithUrl(url, options =>
                    {
                        options.AccessTokenProvider=() => Task.FromResult(userData.Token);
                    })
                    .Build();

                await hubConnection.StartAsync();
                isConnected=true;

                hubConnection.Closed+=async (s) =>
                {
                    isConnected=false;
                    await hubConnection.StartAsync();
                    isConnected=true;
                };

                hubConnection.On<string>("notification", m =>
                {
                    _notifications.Add(m);
                    OnNotificationRecieved(null, null);
                });
            }

            return isConnected;
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
