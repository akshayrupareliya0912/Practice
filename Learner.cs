using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akshay
{
    public class Learner
    {
        public string Name { get; set; }
        public Learner() 
        {
            Name = Name;
        }

        //Learner method
        public Learner(string name)
        {
            Name = name;
        }

        public void Learn()
        {
            Console.WriteLine($"Student Name is {Name}.");
        }
    }
    public class Student:Learner
    {
        public string StudentId { get; set; }

        public Student(string name, string studentId): base(name)
        {
            StudentId = studentId;
        }
        public void SubmitAssignment()
        {
            Console.WriteLine($"{Name} (ID: {StudentId}) has submitted an assignment.");
        }
    }
    public class GraduateStudent : Student
    {
        public String ThesisTopic { get; set; }

        public GraduateStudent(string name, string studid, string thesistopic) : base(name, studid) 
        {
            ThesisTopic = thesistopic;
        }
        public void Research() 
        {
            Console.WriteLine($"{Name} is researching the thesis topic: \"{ThesisTopic}\".");

        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            GraduateStudent Gs = new GraduateStudent("Akshay", "2501", "Coding");

            Gs.Learn();
            Gs.SubmitAssignment();  
            Gs.Research();  
        }
    }
}
