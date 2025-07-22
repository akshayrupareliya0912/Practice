/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akshay
{
    public class StackExample
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(); 

            stack.Push("Akshay");
            stack.Push("Ruparelia");
            stack.Push(5.11f);
            stack.Push(true);
            stack.Push(67.8);
            stack.Push('A');

            foreach (object data in stack)
            {
                Console.WriteLine($"{data}");
            }

            //Delete
            Console.WriteLine($"Deleteing Element {stack.Pop()} ");

            foreach (object da in stack) 
            {
                Console.WriteLine($"{da}");
            }

            // Topmost element
            Console.WriteLine($"Topmost element of Stack is {stack.Peek()}");

            //Contains
            if (stack.Contains("Akshay"))
            {
                Console.WriteLine("Hello Akshay");
            }
            else {
                Console.WriteLine("Akshay name is not found");
            }

            //Clone stack
            Stack clonestack =(Stack)stack.Clone();

            foreach (object clonstk in clonestack) {
                Console.WriteLine($"{clonstk}");
            }
        }
    }
}
*/