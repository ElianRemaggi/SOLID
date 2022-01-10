using System.Threading.Tasks;

namespace OpenClose
{
    public class NotificationSmsService : INotification
    {
        private readonly string _phoneNumber;
        private readonly string _subject;

        public NotificationSmsService(string phoneNumber, string subject)
        {
            _phoneNumber = phoneNumber;
            _subject = subject;
        }

        public async Task Notifiy()
        {
            // Lógica para enviar la notificación
        }
    }