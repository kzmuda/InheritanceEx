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

        public decimal Total()
        {
            decimal total = 0;
            foreach(Account element in bank)
            {

                if (element is SavingAccount e1)
                {
                    //SavingAccount e1 = (SavingAccount)element;
                    total = total + e1.balance + e1.interest;
                }
                else if (element is Account)
                {
                    total += element.balance;
                }

            }
            return total;
        }
    }
}
