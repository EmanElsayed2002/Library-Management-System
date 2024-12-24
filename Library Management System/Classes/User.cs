using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class User
    {

        public string Name { get; set; }

        public User()
        {
            
        }

        public User(string name)
        {
            Name = name;
        }


        public void DisplayBook(Library library)
        {

        }

        public void BorrowBook(Book book , Library library)
        {

        }

        public void Display()
        {

        }
    }
}
