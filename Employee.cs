//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;

//namespace Akshay
//{
//    public class Employee
//    {
//        public string Name { get; set


//                ; }
//        public int Salary { get; set; }

//        public Employee(string name, int salary)
//        {
//            Name = name;
//            Salary = salary;
//        }

//        public void work()
//        {
//            Console.WriteLine($"Employee Name is {Name}");
//            Console.WriteLine($"Employee Name is {Salary}");
//        }
//    }
//    public class Teacher : Employee
//    {
//        public string Subject { get; set; }

//        public Teacher(string subject, string name, int salary) : base(name, salary)
//        {
//            Subject = subject;
//        }
//        public void Teach()
//        {
//            Console.WriteLine($"{Name} is Subject is {Subject}");
//        }
//    }
//    public class SeniorTeacher : Teacher
//    {
//        public int YearsExperience { get; set; }
//        public SeniorTeacher(string name, int salary, string subject, int yearsexperience) : base(subject, name, salary)
//        {
//            YearsExperience = yearsexperience;
//        }
//        public void Mentor()
//        {
//            Console.WriteLine($"Employee have {YearsExperience} of Experience");
//        }
//    }

//    class program
//    {
//        public static void Main(string[] args)
//        {
//            SeniorTeacher ST = new SeniorTeacher("Harshal", 15245, "SQL & .Net", 15);
//            ST.work();
//            ST.Teach();
//            ST.Mentor();
//        }

//    }
//}