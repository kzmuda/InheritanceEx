using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.BankManager
{
    public class Account
    {
        protected decimal balance;

        public Account(decimal balance)
        {
            this.balance = balance;
        }

        public virtual decimal GetBalance()
        {
            return balance;
        }

    }
}
