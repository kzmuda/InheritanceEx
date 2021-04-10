using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.BankManager
{
    public class BasicAccount
    {
        private decimal balance;
        private decimal interests;

        public BasicAccount(decimal balance, decimal interests)
        {
            this.balance = balance;
            this.interests = interests;
        }

        public BasicAccount(decimal balance)
        {
            this.balance = balance;
            this.interests = 0;
        }

        public decimal GetBalance()
        {
            return this.balance + this.interests;
        }
    }
}
