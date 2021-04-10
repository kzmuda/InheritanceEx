using System;
using Polymorphism.BankManager;

using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(20);
            //a1.balance = 20;
            SavingAccount a2 = new SavingAccount(10, 2);
            //a2.balance = 10;
            //a2.interest = 2;
            List<Account> list = new List<Account> { a1, a2 };

            SavingAccount a3 = new SavingAccount(30, 10);


            Bank bank = new Bank(list);
            bank.AddAccountToList(a3);
            
            Console.WriteLine(bank.Total());



            /*OrderItem apple = new OrderItem("apple", 2, (decimal)3.50);
            OrderItemWithPackage eggs = new OrderItemWithPackage("eggs", 10, 6, "package", 2);
            Order order = new Order();
            
            order.AddItemToList(apple);
            order.AddItemToList(eggs);
            order.PrintOrder();*/
        }
    }
}