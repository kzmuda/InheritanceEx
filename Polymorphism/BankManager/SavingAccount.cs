using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.BankManager
{
    class SavingAccount: Account
    {
        private decimal interest;

        public SavingAccount(decimal balance, decimal interest): base(balance)
        {
            this.interest = interest;
        }

        public override decimal GetBalance()
        {
            return base.GetBalance() + interest;
        }
    }
}
