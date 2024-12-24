using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class Library
    {
        Book[] books;
        int cntBorrowBooks = 0;
        int cntBooks = 0;
        Book[] borrowBooks;

        public Library()
        {

            //Console.WriteLine("Your Library Is Initalized :)");
        }


        public void Display()
        {
            foreach (var book in books)
            {
                if (book != null)
                {
                    Console.WriteLine($"\t\t\t\t\t\tBookName:{book.Title}|BookAuthor:{book.Author}|BookPublishedYear:{book.Year}");
                }
            }
        }

        public void Add(Book book)
        {
            if (books != null)
            {

                if (books.Contains(book))
                {
                    Console.WriteLine("\t\t\t\t\t\tBooks Exists Already!!");
                }
                else
                {
                    int len = books.Length;
                    Book[] dist = new Book[len + 1];
                    for (int i = 0; i < books.Length; i++)
                    {
                        dist[i] = books[i];
                    }
                    dist[len] = book;
                    books = dist;
                    Console.WriteLine("\t\t\t\t\t\tBooks Added Successfully :)");
                }
            }
            else
            {
                books = new Book[] { book };
                Console.WriteLine("\t\t\t\t\t\tBooks Added Successfully :)");
            }
        }



        public int GetCountOfBooks()
        {
            return books.Length;
        }



        public void Remove(string bookName)
        {
            if (books is null || books.Length == 0)
            {
                Console.WriteLine("\t\t\t\t\t\tBook Doesn't Exist :)");
                return;
            }

            bool found = false; 

            foreach (var book in books)
            {
                if (book.Title == bookName)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("\t\t\t\t\t\tBook Doesn't Exist!!");
                return;
            }

            int len = books.Length;
            Book[] dist = new Book[len - 1];
            int idx = 0;

            for (int i = 0; i < len; i++)
            {
                if (books[i].Title == bookName)
                {
                    continue; 
                }
                dist[idx++] = books[i];
            }

            books = dist;
            Console.WriteLine("\t\t\t\t\t\tBook Removed Successfully :)");
        }

        public void BorrowBook(Book book)
        {
            if (books.Contains(book))
            {
                int len = borrowBooks.Length, idx = 0;
                Book[] dist = new Book[len + 1];
                for (int i = 0; i < len; i++)
                {
                    dist[i] = borrowBooks[i];
                }
                dist[len] = book;
                borrowBooks = dist;
                Remove(book.Title);
            }
            else
            {
                Console.WriteLine("\t\t\t\t\t\tBook Doesn't Exists :)");
            }
        }
    }
}
