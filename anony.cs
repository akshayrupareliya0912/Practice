/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akshay
{
    internal class anony
    {
        class Person
        {
            private string Name;
            private int Age;

            static void Main(string[] args)
            {

                var person1 = new { Name = "John", Age = 30 };
                var person2 = new { Name = "John", Age = 30 };
                // Compare the two anonymous types
                bool areEqual = person1.Equals(person2);
                Console.WriteLine("Are person1 and person2 equal");
                Console.WriteLine(areEqual);

                *//*var student = new
                {
                    Name = "Akshay",
                    Age = 22,
                    Address = new
                    {
                        Street = "Harinager-3",
                        City = "Surat" }
                    };
                // Accessing nested properties
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Age: {student.Age}");
                Console.WriteLine($"Address: {student.Address.Street}");
                Console.WriteLine($"City: {student.Address.City}");
*/
                /* var people = new List<Person>
                 {
                     new Person { Name = "Akshay",Age = 15},
                     new Person { Name = "Lucky", Age = 30 },
                     new Person { Name = "Sarah", Age = 25 },
                 };
                 var Adult = people
                     .Where(p => p.Age >= 18)
                     .Select(p => new { p.Name,Adult = p.Age >= 18 });

                 foreach (var Person in Adult)
                 {
                     Console.WriteLine($"Name: {Person.Name}, IsAdult:{Person.Adult}");
                 }*//*


                // Example of anonymous
                *//*  var person = new {Name = "Akshay",Age = 25};
                  Console.WriteLine($"Name: {person.Name}");
                  Console.WriteLine($"Age: {person.Age}");*//*
            }
        }
    }
  
}
*/