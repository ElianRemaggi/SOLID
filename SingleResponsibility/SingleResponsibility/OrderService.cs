using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class OrderService
    {
        private readonly NotificationService _notificationService;

        public OrderService(NotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public async Task Add(Order order)
        {
            var message = new MailMessage("sales@admin.com", order.ClientEmail)
            {
                Subject = "Se le asignó una compra",
                Body = "Estimado,\n Hemos creado su nueva orden de compra .."
            };

            await this._notificationService.SendEmail(message);
        }
    }

    /*
     Hacemos que el código sea más fácil de mantener al tener las responsabilidades separadas en distintas clases.
     */

}