using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
     class Library
    {
        List<Book> books = new List<Book>();
        List<Member> members = new List<Member>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully.");
        }

        public void AddMember(Member member)
        {
            members.Add(member);
            Console.WriteLine("Member added successfully.");
        }

        public void BorrowBook(string title, string memberId)
        {
            var book = books.Find(b => b.Title == title && !b.IsBorrowed);
            var member = members.Find(m => m.UserID == memberId);

            if (book == null)
            {
                Console.WriteLine("Book not available.");
            }
            else if (member == null)
            {
                Console.WriteLine("Member not found.");
            }
            else
            {
                book.IsBorrowed = true;
                member.BorrowedBooks.Add(title);
                Console.WriteLine($"{member.Name} borrowed {title}.");
            }
        }

        public void ReturnBook(string title, string memberId)
        {
            var book = books.Find(b => b.Title == title && b.IsBorrowed);
            var member = members.Find(m => m.UserID == memberId);

            if (book == null || member == null || !member.BorrowedBooks.Contains(title))
            {
                Console.WriteLine("Invalid return request.");
            }
            else
            {
                book.IsBorrowed = false;
                member.BorrowedBooks.Remove(title);
                Console.WriteLine($"{member.Name} returned {title}.");
            }
        }

        public void DisplayAvailableBooks()
        {
            Console.WriteLine("Available Books:");
            foreach (var book in books)
            {
                if (!book.IsBorrowed)
                {
                    book.DisplayDetails();
                }
            }
        }

        public void DisplayMembers()
        {
            Console.WriteLine("Library Members:");
            foreach (var member in members)
            {
                member.DisplayDetails();
            }
        }
    }
}
