using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Manager: Employee
    {
        public Manager(string firstName, string lastName, decimal salary) : base(firstName, lastName, salary * (decimal)1.1)
        {
        }

        // public new void WhoAmIWithSalary()
        // {
        //     Console.Out.WriteLine($" {this.LastName} - zarabiam {this.Salary * (decimal)1.1 }");
        // }
    }
}
