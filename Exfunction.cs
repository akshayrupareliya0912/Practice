//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Akshay{ 
//    internal class Exfunction
//    {
        
//       static void Main(string[] args)
//        {
//            Exfunction ef = new Exfunction();

//            //Console.Write("Enter Your Name:- ");
//            //String name = Console.ReadLine();
//            //Console.WriteLine($"{name} You have successfully login");
//            double p, q;
//            (p, q) = ef.getData();
//            bool flag = false;
//            do {
//                Console.Write("1. Addition \n2. Substraction \n3. Multiplication \n4. Division \n5.Average  \n6.Exit \n\n Enter your Choice : ");
//                double choice = Convert.ToDouble(Console.ReadLine());
//                switch (choice)
//                {
//                    case 1:
//                        double ans = ef.Additon(p,q);
//                        Console.WriteLine($"Addation of two numbers :- {ans} ");
//                        break;

//                    case 2:
//                        double sub = ef.Substraction(p, q);
//                        Console.WriteLine($"Substraction of two numbers :- {sub} ");
//                        break;

//                    case 3:
//                        double mul = ef.Multiplication(p, q);
//                        Console.WriteLine($"Multiplication of two numbers :- {mul} ");
//                        break;

//                    case 4:
//                        double div = ef.Division(p, q);
//                        Console.WriteLine($"Division of two numbers :- {div} ");
//                        break;
//                    case 5:
//                        Double avg = ef.Average(p, q);
//                        Console.WriteLine($"Average of two number:- {avg}");
//                        break;
//                    case 6:
//                        flag = true;
//                        break;
//                default:
//                        Console.WriteLine("Invalid Choice");
//                        break;
//                }
//            }while (flag != true);
//       }
//        public (double, double) getData() {
//            double a,b; 
//            Console.Write("Enter Value 1: ");
//            a = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Enter Value 2: ");
//            b = Convert.ToDouble(Console.ReadLine());
//            return (a, b);
//        }
//        public double Additon(double x, double y)
//        {
//            /*double a,b,c;
//            Console.WriteLine("Addition");
//            Console.Write("Enter Value 1: ");
//            a = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Enter Value 2: ");
//            b = Convert.ToDouble(Console.ReadLine());*/

//            double c = x + y;
//            return c;
//        }
//        public double Substraction(double x, double y)
//        {
//            double  c = x - y;
//            return c;
//        }
//        public double Multiplication(double x, double y)
//        {
//            double c = x * y;
//            return c;
//        }
//        public double Division(double x, double y)
//        {
//            double c = x / y;
//            return c;
//        }
//        public double Average(double x, double y)
//        {
//            double c = x + y;
//            double avg = c/2;
//            return avg;
//        }
     
//    }
//}