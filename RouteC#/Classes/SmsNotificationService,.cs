using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_.Classes
{
    public class SmsNotificationService_ : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Message sent to {recipient} through SMS: \n {message}");
        }
    }
}
