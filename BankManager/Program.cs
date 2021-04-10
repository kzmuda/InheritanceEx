using System;
using System.Collections.Generic;

namespace BankManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            a1.balance = 20;
            SavingAccount a2 = new SavingAccount();
            a2.balance = 10;
            a2.interest = 2;
            List<Account> list = new List<Account>() { a1, a2 };
/*            list.Add(a1);
            list.Add(a2)*/;
            Bank bank = new Bank(list);
            Console.WriteLine(bank.Total());
        }
    }
}
