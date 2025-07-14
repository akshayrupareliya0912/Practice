/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akshay
{
    public class library
    {
        public class LibraryItems
        {
            public string Title { get; set; }
            public string Itemid { get; set; }

            public LibraryItems(string title, string itemid)
            {
                Title = title;
                Itemid = itemid;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Title of book{Title}");
                Console.WriteLine($"Book ID{Itemid}");
            }
        }
    
        public class Book : LibraryItems
        {
            public string Author { get; set;}
            private bool isBorrowed;
            public Book(string title, string itemid, string author) : base(title,itemid) 
            {
                Author = author;
                isBorrowed = false;
            }     
            public void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Author: {Author}");
                Console.WriteLine($"Borrowed: {(isBorrowed ? "Yes" : "No")}");
            }
            public void BorrowBook()
            {
                if (isBorrowed)
                {
                    Console.WriteLine($"The Book \"{Title}\" has been already borrowed.");
                }
                else {
                    isBorrowed = true;
                    Console.WriteLine($"The book\"{Title}\" is already borrowed.");
                }
            }
        }
        class Bookdetail 
        {
            static void Main(string[] args) 
            {

                Book book1 = new Book("1984","B101","George orwell");
                Console.WriteLine("Book INFO");
                book1.DisplayInfo();
                Console.WriteLine("\n Borrowing the book");
                book1.BorrowBook();
                Console.WriteLine("Updated book INFO");
                book1.DisplayInfo();
            }
        }
    }
}
*/