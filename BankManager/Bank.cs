using System;
using System.Collections.Generic;
using System.Text;

namespace BankManager
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
            decimal total=0;
            foreach(Account element in bank)
            {
                if (element is SavingAccount el)
                {
                    //SavingAccount el = (SavingAccount)element;
                    total += el.balance + el.interest;
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
