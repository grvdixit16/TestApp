using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    using System;

    // Define a simple service interface
    public interface IMessageService
    {
        void SendMessage(string message);
    }

    // Implementation of the service interface
    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending email: {message}");
        }
    }

    // Consumer class that uses dependency injection
    public class NotificationService
    {
        private readonly IMessageService messageService;

        public NotificationService(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        public void Notify(string message)
        {
            messageService.SendMessage(message);
        }
    }

    class Program
    {
        static void Main()
        {
            // Using dependency injection to inject the service into the consumer
            IMessageService emailService = new EmailService();
            var notificationService = new NotificationService(emailService);

            notificationService.Notify("Hello, you've got mail!");
        }
    }
}
