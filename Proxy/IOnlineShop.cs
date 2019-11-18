using System;

namespace Proxy
{
    public interface IOnlineShop
    {
        void ProcessOrder(string order);
        string GetOrder();
        void DeliverShipment();
        void ProcessPayment(string payment, bool isProxy);
    }
}
