using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NotSingleResponsibility
{
    public class OrderService
    {
        private readonly SmtpClient _smtpClient;

        public async Task Add(Order order)
        {
            // 01. Codigo para crear la orden

            // 02. Notificar al cliente

            var message = new MailMessage("sales@admin.com", order.ClientEmail)
            {
                Subject = "Se la asigno una compra",
                Body = "Estimado,\n Hemos creado su nueva orden de compra .."
            };
            await this.SendCustomerNotificaction(message);
        }

        private async Task SendCustomerNotificaction(MailMessage message)
        {
            await _smtpClient.SendMailAsync(message);
        }
        /*
         * El código en general esta bien, pero el problema es que comparte la responsabilidad de mandar el correo, la cual no esta dentro de su dominio.
         */

    }
}
