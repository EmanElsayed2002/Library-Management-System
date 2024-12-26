using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    class Member : User
    {
        public List<string> BorrowedBooks = new List<string>();
        public override void DisplayDetails()
        {
            Console.WriteLine($"Member Name: {Name}, ID: {UserID}");
            Console.WriteLine("Borrowed Books:");
            foreach (var book in BorrowedBooks)
            {
                Console.WriteLine($"- {book}");
            }
        }
    }
}
