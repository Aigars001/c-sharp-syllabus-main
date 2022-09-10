using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class Employee : Person
    {
        public string Job { get; }

        public Employee(string name, string lastname, string address, int id, string job) 
            : base(name, lastname, address, id)
        {
            Job = job;
        }

        public override void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}, from {Address}, working as {Job}. ID: {Id}");
        }
    }
}
