using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //A guy orders from Amazon
            OnlineShop amazon = new OnlineShop();
            amazon.ProcessOrder("Toothbrush");
            amazon.ProcessPayment("$6.99", false);
            amazon.DeliverShipment();

            //A guy order from RandomECommerce.net which doesn't have payment processing
            //There is no accessible proxy
            NewOnlineShopWithoutProxy noProxy = new NewOnlineShopWithoutProxy();
            noProxy.ProcessOrder("Thanksgiving Turkey");
            noProxy.ProcessPayment("$40.00", false);
            noProxy.DeliverShipment();

            Console.WriteLine('\n');

            //A guy orders from RandomECommerce.net which doesn't have payment processing
            //The Online Shop is accessed remotely via proxy in order to process payments
            NewOnlineShopProxy eCommerce = new NewOnlineShopProxy();
            eCommerce.ProcessOrder("Halloween costume");
            eCommerce.ProcessPayment("$20.00", true);
            eCommerce.DeliverShipment();
        }
    }
}
