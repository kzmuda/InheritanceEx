using System;

namespace Polymorphizm
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderItem apple = new OrderItem("apple", 2, (decimal)3.50);
            OrderItemWithPackage eggs = new OrderItemWithPackage("eggs", 10, 6);
            Order order = new Order();

            order.AddItemToList(apple);
            order.AddItemToList(eggs);
            order.PrintOrder();

        }
    }
}
