using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akshay
{
    public class Library_Book_System
    {
        internal void AddBook(string v)
        {
            throw new NotImplementedException();
        }

        internal void BorrowBook(int v1, string v2)
        {
            throw new NotImplementedException();
        }

        class Book 
        {
            public string Title { get; set; }
            public int Copies { get; set; }
        }
        class Library 
        {
            List<Book> Availablebooks = new List<Book>();
            Dictionary<int,string > StudentBarrowedBooks= new Dictionary< int, string>();
            Stack<(int StudentId, string bookTitle)> borrowedBooks = new Stack<(int, string)>();
            HashSet<string> borrowedBookTitles = new HashSet<string>();
            Dictionary<string, Queue<int>> waitlist = new Dictionary<string, Queue<int>>();
        }
    }
}
