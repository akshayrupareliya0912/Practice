/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akshay
{
    internal class QueueExample
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("Akshay");
            queue.Enqueue("Ruparelia");
            queue.Enqueue(5.11f);
            queue.Enqueue(true);
            queue.Enqueue(67.8);

            foreach (object Q in queue)
            {
                Console.WriteLine($"{Q}");
            }

            // Dequeue
            Console.WriteLine();
            Console.WriteLine($"Dequeueing Element {queue.Dequeue()} ");
            Console.WriteLine();
            foreach (object Q in queue)
            {
                Console.WriteLine($"{Q}");
            }

            //Peek
            if (queue.Contains("Akshay"))
            {
                Console.WriteLine();
                Console.WriteLine($"Hello {queue.Peek()}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Name not found in Queue");
                Console.WriteLine();
            }

            //Clone
            Queue clonedQueue = (Queue)queue.Clone();
            foreach (var data in clonedQueue)
            {
                Console.WriteLine($"{data}");
                
            }

            //Copy to Array
            object[] array = new object[queue.Count];
            queue.CopyTo(array, 0);
            foreach (object i in array)
            {
                Console.WriteLine($"{i}");

            }
        }
    }
}
*/