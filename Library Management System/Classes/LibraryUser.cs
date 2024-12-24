using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class LibraryUser : User
    {
        public LibraryUser Card { get; set; }

        public LibraryUser(string name)
        {
            Name = name;
        }
        public void BorrowBook(Book book , Library library)
        {

        }
    }

}
