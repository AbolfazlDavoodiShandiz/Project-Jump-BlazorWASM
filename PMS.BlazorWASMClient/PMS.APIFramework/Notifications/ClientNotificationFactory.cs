using PMS.BlazorWASMClient.Utility.DTOs;
using PMS.BlazorWASMClient.Utility.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.Notifications
{
    public class ClientNotificationFactory
    {
        public static IEnumerable<ClientNotification> GenerateNotifications(IEnumerable<NotificationDTO> notificationDTOs)
        {
            var clientNotifications = new List<ClientNotification>();

            foreach (var serverNotification in notificationDTOs)
            {
                ClientNotification clientNotification = new ClientNotification();

                clientNotification.NotificationId = serverNotification.Id;
                clientNotification.FromUsername = serverNotification.CreatedUsername;
                clientNotification.CreateDate = serverNotification.CreateDate;
                clientNotification.IsRead=serverNotification.IsRead;

                string text = $"{serverNotification.RelatedObjectTitle}";

                if (serverNotification.NotificationType == NotificationType.AddProjectMember)
                {
                    text = $"<strong>{serverNotification.CreatedUsername}</strong> Added You to <strong>{serverNotification.RelatedObjectTitle}</strong> Team.";
                }
                else if (serverNotification.NotificationType == NotificationType.AssignTask)
                {
                    text = $"<strong>{serverNotification.CreatedUsername}</strong> Made You Rersponsible For This Task: {serverNotification.RelatedObjectTitle}.";
                }
                else if (serverNotification.NotificationType == NotificationType.ChatMessage)
                {
                    text = $"You Have A New Message From {serverNotification.CreatedUsername}.";
                }

                clientNotification.NotificationText = text;
                clientNotifications.Add(clientNotification);
            }

            return clientNotifications;
        }
    }
}
