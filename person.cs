/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akshay
{
    public class person
    {
        public string Name { get; set; }
        public person(string name)
        {
            Name = name;
        }
        public void Introduce()
        {
            Console.WriteLine($"Student:- {Name}");
        }
    }
    public class Student : person
    {
        public int Grade { get; set; }

        public Student(string name, int grade) : base(name)
        {
            Grade = grade;
        }

        public void AttendClass()
        {
            Console.WriteLine($"{Name} is attending grade {Grade} class.");
        }
    }
    public class HighSchoolStudent : Student
    {
        public string Club { get; set; }

        public HighSchoolStudent(string name, int grade, string club) : base(name, grade)
        {
            Club = club;
        }

        public void JoinClub()
        {
            Console.WriteLine($"{Name} has joined the {Club}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HighSchoolStudent student = new HighSchoolStudent("Akshay", 10, "Math Club");

            student.Introduce();
            student.AttendClass();
            student.JoinClub();
        }
    }
}
*/