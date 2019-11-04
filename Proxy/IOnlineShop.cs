using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IOnlineShop
    {
        void ProcessOrder(string order);
        string GetOrder();
        void DeliverShipment();
        void ProcessPayment(string payment);
    }
}
