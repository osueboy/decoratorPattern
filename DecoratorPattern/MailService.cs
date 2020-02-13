using System;

namespace DecoratorPattern
{
    public class MailService : IMailService
    {
        public void Send(string destiny, string message)
        {
            Console.WriteLine("Se envió el correo a {0}, el mensaje {1}", destiny, message);
        }
    }
}
