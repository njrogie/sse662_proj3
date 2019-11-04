using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class OnlineShop : IOnlineShop
    {
        private string _order;
        public void ProcessOrder(string order)
        {
            Console.WriteLine("The " + order + " was purchased. It will be delivered soon.");
            _order = order;
        }

        public string GetOrder()
        {
            return _order;
        }

        public void DeliverShipment()
        {
            Console.WriteLine(this.GetOrder() + " was delivered!"); //Redesign getOrder!
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("Payment for the " + _order +
                " in the amount of " + payment +
                " was processed.");
        }
    }
}
