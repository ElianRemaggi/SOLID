namespace NoDependencyInversion
{
    public class OrderService
    {
        public readonly MailChimpService _mailService;

        public OrderService(MailChimpService mailService)
        {
            _mailService = mailService;
        }

        public void Create(Order order)
        {
            // TODO: código para crear la orden

            // Enviar notificación de la orden creada
            _mailService.Send();
        }
        /*
         Si funciona bien porque nuestro proveedor actualmente es Mailchimp,
        pero ¿qué pasaría si mañana vamos a trabajar con otro?. 
        Pues vamos a tener que cambiar todas las referencias a MailchimpService.*/
    }
}
