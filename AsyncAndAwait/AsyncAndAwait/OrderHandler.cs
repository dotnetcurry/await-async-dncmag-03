using System;
using System.Collections.Generic;
using System.Linq;

namespace AsyncAndAwait
{
    public class OrderHandler
    {
        private readonly IEnumerable<Order> _orders;
        public OrderHandler()
        {
            _orders = new[]
                {
                    new Order {OrderNumber = "F1", OrderTotal = 100, Reference = "Filip"},
                    new Order {OrderNumber = "F2", OrderTotal = 100, Reference = "Sumit"},
                    new Order {OrderNumber = "F3", OrderTotal = 100, Reference = "Suprotim"},
                    new Order {OrderNumber = "F4", OrderTotal = 100, Reference = "Mahesh"},
                    new Order {OrderNumber = "F5", OrderTotal = 100, Reference = "Greg"},
                    new Order {OrderNumber = "F6", OrderTotal = 100, Reference = "Niraj"},
                    new Order {OrderNumber = "F7", OrderTotal = 100, Reference = "Mehfuz"},
                    new Order {OrderNumber = "F8", OrderTotal = 100, Reference = "Jon"}
                };
        }
        public IEnumerable<Order> GetAllOrders()
        {
            new System.Threading.ManualResetEvent(false).WaitOne(2000);
            return _orders;
        }
    }
}
