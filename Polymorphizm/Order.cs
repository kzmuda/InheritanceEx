using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphizm
{
    class Order
    {
        List<OrderItem> items = new List<OrderItem>();
        
        public void AddItemToList(OrderItem item)
        {
            items.Add(item);
        }
        public decimal SumOrder()
        {
            decimal sum = 0;
            foreach (var item in items)
            {
                sum += item.GetValue();
            }
            return sum;
        }
        public void PrintOrder()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Sum order: {SumOrder()}");
        }
    }
}
