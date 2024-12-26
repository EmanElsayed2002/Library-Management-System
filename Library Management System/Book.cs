using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Book : User
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; set; } = false;

        public override void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Available: {!IsBorrowed}");
        }
    }
}
