using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    public interface INotificationService
    {
        void SendNotification(string recipient,string message);
    }
}
