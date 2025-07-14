//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static Akshay.Persons;

//namespace Akshay
//{
//    public class Persons
//    {
//       public class Person
//        {
//            public string Name { get; set; }
//            public int Age { get; set; }

//            public void Introduce()
//            {
//                Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
//            }
//        }

//        public class Student : Person
//        {
//            public string StudentId { get; set; }
//            private List<DateTime> AttendanceList = new List<DateTime>();

//            public void MarkAttendance()
//            {
//                DateTime today = DateTime.Today;
//                AttendanceList.Add(today);
//                Console.WriteLine($"Attendance marked for {Name} on {today.ToShortDateString()}.");
//            }
//        }

//    }
//    class Program
//    {
//        static void Main()
//        {
//            Student student = new Student
//            {
//                Name = "Akshay",
//                Age = 20,
//                StudentId = "S12345"
//            };

//            student.Introduce();      
//            student.MarkAttendance();  
//        }
//    }
//}

