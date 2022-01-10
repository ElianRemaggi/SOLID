using System.Threading.Tasks;

namespace OpenClose
{

    public class NotificationEmailService : INotification
    {
        private readonly string _to;
        private readonly string _subject;

        public NotificationEmailService(string to, string subject)
        {
            _to = to;
            _subject = subject;
        }

        public async Task Notifiy()
        {
            // Lógica para enviar la ntoification por e-mail
        }
    }
}

