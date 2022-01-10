using System;
using System.Collections.Generic;
using System.Text;

namespace NoOpenClose
{
    class NotificationService
    {
        public async Task Send(List<Notification> notifications)
        {
            foreach (var notification in notifications)
            {

                //Estos condicionales rompen el principio open close
                //Por cada nuevo tipo de notificacion sera necesario modificar este codigo
                if (notification.Type.Equals("sms"))
                {
                    await SendbySMS(notification.PhoneNumber, notification.Subject);
                }

                if (notification.Type.Equals("email"))
                {
                    await SendbyEmail(notification.Email, notification.Subject);
                }
            }
        }

        private async Task SendbySMS(string phoneNumber, string subject)
        {
            // Logica para mandar el SMS
        }

        private async Task SendbyEmail(string to, string subject)
        {
            // Logica para mandar el email
        }
    }
}
