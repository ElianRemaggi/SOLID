using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    class NotificationService
    {
        public async Task Send(List<INotification> notifications)
        {
            foreach (var notification in notifications)
            {
                await notification.Notifiy();
            }
        }
    }
}
