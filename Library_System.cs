/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akshay
{
    internal class Library_System
    {

    *//* List<string> AvailableBooks = new List<string>();
       Dictionary<int, string> StudentBorrowedBooks = new Dictionary<int, string>();
       Stack<(int StudentId, string BookTitle)> UndoBorrowedBooks = new Stack<(int, string)>();
       HashSet<string> BorrowedBookTitles = new HashSet<string>();
       Queue<int> Waitlist = new Queue<int>();*//*

        private List<string> availableBooks = new List<string>();
        private Dictionary<int, List<string>> studentBorrowedBooks = new Dictionary<int, List<string>>();
        private Dictionary<int, Stack<string>> studentUndoStack = new Dictionary<int, Stack<string>>();
        private HashSet<string> uniqueBorrowedBooks = new HashSet<string>();
        private Dictionary<string, Queue<int>> bookWaitlists = new Dictionary<string, Queue<int>>();

        public void AddBook(string BookTitle)
        {
            availableBooks.Add(BookTitle);
        }
        public bool BorrowBook(int StudentId, string BookTitle)
        {
            if (availableBooks.Contains(BookTitle))
            {
                availableBooks.Remove(BookTitle);

                if (!studentBorrowedBooks.ContainsKey(StudentId))
                    studentBorrowedBooks[StudentId] = new List<string>();

                studentBorrowedBooks[StudentId].Add(BookTitle);

                if (!studentUndoStack.ContainsKey(StudentId))
                    studentUndoStack[StudentId] = new Stack<string>();

                studentUndoStack[StudentId].Push(BookTitle);

                Console.WriteLine($"Book '{BookTitle}' Borrowed By Student ID:{StudentId}");
                return true; 
            }
            else
            {
                if (!bookWaitlists.ContainsKey(BookTitle))
                    bookWaitlists[BookTitle] = new Queue<int>();

                bookWaitlists[BookTitle].Enqueue(StudentId);
                Console.WriteLine($"Book '{BookTitle}' is not available. Student ID:{StudentId} added to waitlist.");
                return false;
            }
        }

        public void ReturnBook(int StudentId, string BookTitle)
        {
            if (studentBorrowedBooks.ContainsKey(StudentId) && studentBorrowedBooks[StudentId].Contains(BookTitle))
            {
                studentBorrowedBooks[StudentId].Remove(BookTitle);
                availableBooks.Add(BookTitle);
                Console.WriteLine($"Book '{BookTitle}' Returned By Student ID:{StudentId}");

                if (bookWaitlists.ContainsKey(BookTitle) && bookWaitlists[BookTitle].Count > 0)
                {
                    int nextStudent = bookWaitlists[BookTitle].Dequeue();
                    Console.WriteLine($"'{BookTitle}' reassigned to student {nextStudent} from waitlist.");
                    BorrowBook(nextStudent, BookTitle);
                }
            }
        }

        public void UndoLastBorrow(int StudentId)
        {
            if (studentUndoStack.ContainsKey(StudentId) && studentUndoStack[StudentId].Count > 0)
            {
                string lastBook = studentUndoStack[StudentId].Pop();
                Console.WriteLine($"Undo Borrow: Book '{lastBook}' for Student ID:{StudentId}");
                ReturnBook(StudentId, lastBook);
            }
        }

        public List<string> GetAvailableBooks()
        {
            return new List<string>(availableBooks);
        }

        public List<string> GetUniqueBorrowedBooks()
        {
            return new List<string>(uniqueBorrowedBooks);
        }

        public class program
        {
            public static void Main(string[] args)
            {
                Library_System library = new Library_System();

                library.AddBook(".Net");
                library.AddBook("C#");
                library.AddBook("Java");
                library.AddBook("Flutter");

                library.BorrowBook(101, ".Net");
                library.BorrowBook(102, "C#");

                library.ReturnBook(101, ".Net");

                library.UndoLastBorrow(101);


                Console.WriteLine("Available Books:");
                foreach (object Books in library.GetAvailableBooks())
                {
                    Console.WriteLine($" - {Books}");
                }

                Console.WriteLine("Unique Borrowed Books:");
                foreach (string book in library.GetUniqueBorrowedBooks())
                {
                    Console.WriteLine($" - {book}");
                }
            }
        }
    }
}*/