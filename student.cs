/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akshay
{
    public class Student
    {
        public string Name { get; set; }
        public int GradeLevel { get; set; }

        public Student(string name, int gradeLevel)
        {
            Name = name;
            GradeLevel = gradeLevel;
        }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying in grade {GradeLevel}.");
        }
    }

    public class ExamStudent : Student
    {
        public int ExamScore { get; set; }

        public ExamStudent(string name, int gradeLevel, int examScore)
            : base(name, gradeLevel)
        {
            ExamScore = examScore;
        }

        public void DisplayResult()
        {
            Console.WriteLine($"{Name}'s Exam Score: {ExamScore}");
            if (ExamScore >= 50)
            {
                Console.WriteLine("Result: Pass");
            }
            else
            {
                Console.WriteLine("Result: Fail");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExamStudent student1 = new ExamStudent("Akshat", 10, 72);
            student1.Study();
            student1.DisplayResult();

            Console.WriteLine();

            ExamStudent student2 = new ExamStudent("Lucky", 9, 45);
            student2.Study();
            student2.DisplayResult();
        }
    }
}
*/