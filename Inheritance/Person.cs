using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Inheritance
{
    internal class Person
    {
        protected string FirstName { get; set; }

        public string LastName { get; set; }

        public int YearOfBirth { get; set; }

        public Person(string firstName)
        {
            FirstName = firstName;
        }

        

        public Person(string firstName, string lastName)
        {
            //Console.Out.WriteLine("tworzę ludzika");
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, int yearOfBirth)
        {
            //Console.Out.WriteLine("tworzę ludzika + rok urodzenia");
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
        }


        public override string ToString()
        {
            return $"My Name is {this.LastName}. {this.FirstName} {this.LastName}";
        }

        public bool IsAdult()
        {
            return DateTime.Today.Year - YearOfBirth > 18;
        }
    }
}
