using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class Student : Person
    {
        public double Gpa { get; }

        public Student(string name, string lastName, string address, int id, double gpa) 
            : base(name, lastName, address, id)
        {
            Gpa = gpa;
        }

        public override void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}, from {Address}, GPA: {Gpa}. ID: {Id}");
        }
    }
}
