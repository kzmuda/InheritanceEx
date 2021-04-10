using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class Order
    {
        private List<OrderItem> items = new List<OrderItem>();

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
                Console.Out.WriteLine(item);
            }

            Console.Out.WriteLine($"Sum order: {SumOrder()}");
        }
    }
}