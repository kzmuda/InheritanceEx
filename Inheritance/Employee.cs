using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Employee: Person
    {
        public decimal Salary { get; set; }

        public Employee(string firstName, string lastName) : base(firstName, lastName)
        {
            //Console.Out.WriteLine("tworzę pracownika");
        }

        public Employee(string firstName, string lastName, decimal salary) : base(firstName, lastName)
        {
            Salary = salary;
            //Console.Out.WriteLine("tworzę pracownika + salary");
        }

        public Employee(string firstName, string lastName, int yearOfBirth) : base(firstName, lastName, yearOfBirth)
        {
        }

        public void WhoAmIWithSalary()
        {
            Console.Out.WriteLine($" {this.FirstName} {this.LastName} - zarabiam {this.Salary}");
        }
    }
}
