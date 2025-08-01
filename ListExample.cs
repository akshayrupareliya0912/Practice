/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Akshay
{
    public class ListExample
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Mudit");
            names.Add("Akshay");
            names.Add("Siddhi");
            names.Add("Siddharth");


            names.Sort();

            names.Reverse();
            Console.WriteLine("\nNames in Descending Order");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            Console.WriteLine("Names of people are selected foreach");
            foreach (object i in names)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine();
            Console.WriteLine("Names of people are selected using for loop");

            for (var i = 0; i < names.Count; i++)
            {
                var name = names[i];
                Console.WriteLine($"{name}");
            }
            List<string> newnames = new List<string>
            {
                "lucky",
                "Kishan"
            };
            names.InsertRange(2, newnames);

            foreach (var name in newnames)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine();
            Console.WriteLine("Using index position");
            Console.WriteLine($"First Name: {names[0]}");
            Console.WriteLine($"Last Name: {names[1]}");


            // Removing an item from the list
            Console.WriteLine($"Removing Akshay{names.Remove("Akshay")}");
            names.Clear();
            foreach (object i in names)
            {
                Console.WriteLine(i);
            }

            // Copying the list to another list
            string[] namess = { "Akshay", "Siddhi", "Siddharth", "Mudit" };
            List<string> copiedList = new List<string>(namess);
            foreach (var name in copiedList)
            {
                Console.WriteLine(name);
            }

            //checking using if-condition
            if (namess.Contains("Mudit"))
            {
                Console.WriteLine("List contains Mudit");
            }
            else
            {
                Console.WriteLine("List does not contain Mudit");
            }
        }
    }
}
*/