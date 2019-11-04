using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class NewOnlineShopProxy : IOnlineShop
    {
        private string _order;
        private OnlineShop onlineShop = new OnlineShop();

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
            Console.WriteLine(this.GetOrder() + " was delivered!");
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("New online shop cannot process" +
                " payments yet!");
            onlineShop.SetOrder(_order);
            onlineShop.ProcessPayment(payment);
        }
    }
}
