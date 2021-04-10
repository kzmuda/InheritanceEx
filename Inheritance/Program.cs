using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {

        static void Print(Person person)
        {
            if (person.IsAdult())
            {
                Console.Out.WriteLine("Witamy w monopolowym");
            }
            else
            {
                Console.Out.WriteLine("Witamy z zabawkowym");
            }

            person.LastName = "Nowak";
        }

        static void Main(string[] args)
        {
            

            // Manager manager = new Manager("Ania", "Nowak", 2000);
            //
            // Employee m = manager as Employee;
            //
            // //Employee manager = new Manager("Ania", "Nowak", 2000);
            //
            // employee.WhoAmIWithSalary();
            // m.WhoAmIWithSalary();

            // List<Employee> employees = new List<Employee> { employee, manager };
            //
            // foreach (var employee1 in employees)
            // {
            //     employee1.WhoAmIWithSalary();
            // }

            // employee.WhoAmIWithSalary();
            // manager.WhoAmIWithSalary();
            //
            //
            // Employee manager1 = new Manager("Ania", "Nowak", 2000);
            // manager1.WhoAmIWithSalary();


        }
    }
}
