using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.BankManager
{
    public class BasicBank
    {
        List<BasicAccount> bank;

        public BasicBank(List<BasicAccount> list)
        {
            bank = list;
        }


        public void AddAccountToList(BasicAccount account)
        {
            bank.Add(account);
        }

        public decimal Total()
        {
            decimal total = 0;
            foreach (BasicAccount element in bank)
            {
                total += element.GetBalance();
            }
            return total;
        }

    }
}
