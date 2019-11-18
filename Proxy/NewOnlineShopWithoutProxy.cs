using System;

namespace Proxy
{
    class NewOnlineShopWithoutProxy : IOnlineShop
    {
        private string _order;

        public void ProcessOrder(string order)
        {
            Console.WriteLine(order + " was purchased. It will be delivered soon by new shop.");
            _order = order;
        }

        public string GetOrder()
        {
            return _order;
        }

        public void DeliverShipment()
        {
            Console.WriteLine(this.GetOrder() + " was not delivered!");
        }

        public void ProcessPayment(string payment, bool isProxy)
        {
            Console.WriteLine("New online shop cannot process" +
                " payments yet!");
        }
    }
}
