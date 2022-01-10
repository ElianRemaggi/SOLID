using System.Collections.Generic;

namespace OpenClose
{
    class CodigoCliente
    {
        public async void notificar()
        {
            var notificationsx = new List<INotification>
            {
                new NotificationEmailService("customer@email.com", "El motivo del correo"),
                new NotificationSmsService("+05199999", "El asunto del mensaje de texto"),
                // .. podemos implementar más notificaciones
            };

            var notificationService = new NotificationService();
            await notificationService.Send(notificationsx);
        }
    }
}
