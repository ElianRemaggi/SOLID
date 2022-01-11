namespace DependencyInversion
{
    public class OrderService
    {
        public readonly IMailService _mailService;

        public OrderService(IMailService mailService) //Esta abstraccion permite enviar el mail independientemente de que servicio sea
        {
            _mailService = mailService;
        }

        public void Create(Order order)
        {
            // TODO: código para crear la orden

            // Enviar notificación de la orden creada
            _mailService.Send();
        }
    }
}
