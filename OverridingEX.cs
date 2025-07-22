/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akshay
{
    public class OverridingEX
    {

        class Animal
        {
            public virtual void AnimalSound()
            {
                Console.WriteLine("Animal speaks");
            }
        }
        class Dog : Animal
        {
            public override void AnimalSound()
            {
                Console.WriteLine("Dog barks");
            }
        }
        class Cat : Animal
        {
            public override void AnimalSound()
            {
                Console.WriteLine("Cat meows");
            }
        }

        class AnimalTest
        {
            static void Main(string[] args)
            {
                Animal D = new Dog();
                Animal C = new Cat();
                D.AnimalSound(); 
                C.AnimalSound();
                Console.ReadKey();
            }

        }
    }
}
*/