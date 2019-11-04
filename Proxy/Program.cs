using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //A guy orders from Amazon
            OnlineShop amazon = new OnlineShop();
            amazon.ProcessOrder("Toothbrush");
            amazon.ProcessPayment("$6.99");
            amazon.DeliverShipment();

            //A guy orders from RandomECommerce.net which doesn't have payment processing
            NewOnlineShopProxy eCommerce = new NewOnlineShopProxy();
            eCommerce.ProcessOrder("Halloween costume");
            eCommerce.ProcessPayment("$20.00");
            eCommerce.DeliverShipment();
        }
    }
}
