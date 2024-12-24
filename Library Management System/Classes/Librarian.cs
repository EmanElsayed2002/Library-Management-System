using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class Librarian : User
    {
        public int EmployeeNumber { get; set; }

        public Librarian(string name)
        {
            Name = name;
        }

        public void Add(Book book , Library library)
        {
            library.Add(book);

        }

        public void Remove(string bookTitle, Library library)
        {
            library.Remove(bookTitle);
        }

        public void Display(Library library)
        {
            library.Display();

        }
    }
}
