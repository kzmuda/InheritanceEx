using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.BankManager
{
    class Bank
    {
        List<Account> bank;

        public Bank(List<Account> list)
        {
            bank = list;
        }


        public void AddAccountToList(Account account)
        {
            bank.Add(account);
        }

        public decimal Total()
        {
            decimal total = 0;
            foreach(Account element in bank)
            {
                total += element.GetBalance();
                /*
                if (element is SavingAccount e1)
                {
                    //SavingAccount e1 = (SavingAccount)element;
                    total += element.GetBalance();
                }
                else if (element is Account)
                {
                    total += element.GetBalance();
                }
                */
            }
            return total;
        }
    }
}
