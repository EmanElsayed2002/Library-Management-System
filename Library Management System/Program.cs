using System;
using Library_Management_System.Models;

namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\t\t\t\t\tWelcome to the Library System Management");

                Library library = new Library();

                int userChoice = GetUserChoice("\t\t\t\t\t\tChoose Your Role:\n" +
                                               "\t\t\t\t\t\t1- Librarian\n" +
                                               "\t\t\t\t\t\t2- Regular User\n" +
                                               "\t\t\t\t\t\t3- Exit\n",
                                               1, 3);

                if (userChoice == 3)
                {
                    Console.WriteLine("\t\t\t\t\tExiting the Library Management System. Goodbye!");
                    break;
                }

                if (userChoice == 1)
                    LibrarianMethods(library);
                else if (userChoice == 2)
                    UserMethods(library);

            } while (true); // Infinite loop for the program
        }

        static int GetUserChoice(string prompt, int minChoice, int maxChoice)
        {
            int choice;
            do
            {
                Console.WriteLine(prompt);
                Console.Write("\t\t\t\t\t\tEnter Your Choice: ");
            } while (!int.TryParse(Console.ReadLine(), out choice) || choice < minChoice || choice > maxChoice);

            return choice;
        }

        static void LibrarianMethods(Library library)
        {
            Console.Write("\t\t\t\t\t\tEnter the Librarian Name: ");
            string librarianName = Console.ReadLine();
            Librarian librarian = new Librarian(librarianName);

            Console.WriteLine($"\t\t\t\t\t\tWelcome {librarian.Name}");

            char repeatOperation;
            do
            {
                int choice = GetUserChoice("\t\t\t\t\t\tWhat would you like to do?\n" +
                                           "\t\t\t\t\t\t1- Add Books\n" +
                                           "\t\t\t\t\t\t2- Remove Books\n" +
                                           "\t\t\t\t\t\t3- Display Books\n" +
                                           "\t\t\t\t\t\t4- Exit\n",
                                           1, 4);

                if (choice == 4) break;

                switch (choice)
                {
                    case 1:
                        AddBook(librarian, library);
                        break;
                    case 2:
                        RemoveBook(librarian, library);
                        break;
                    case 3:
                        DisplayBooks(librarian, library);
                        break;
                }

                Console.Write("\t\t\t\t\t\tDo you want to perform another operation? (Y/N): ");
                repeatOperation = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();
            } while (repeatOperation == 'y');
        }

        static void AddBook(Librarian librarian, Library library)
        {
            Console.WriteLine("\t\t\t\t\t\tEnter Book Details:");
            Console.Write("\t\t\t\t\t\tTitle: ");
            string title = Console.ReadLine();
            Console.Write("\t\t\t\t\t\tAuthor: ");
            string author = Console.ReadLine();
            Console.Write("\t\t\t\t\t\tYear: ");
            int year = int.Parse(Console.ReadLine());

            Book book = new Book(title, author, year);
            librarian.Add(book, library);
        }

        static void RemoveBook(Librarian librarian, Library library)
        {
            Console.Write("\t\t\t\t\t\tEnter the Title of the Book to Remove: ");
            string title = Console.ReadLine();
            librarian.Remove(title, library);
        }

        static void DisplayBooks(Librarian librarian, Library library)
        {
            Console.WriteLine("\t\t\t\t\t\tBooks in the Library:");
            librarian.Display(library);
        }

        static void UserMethods(Library library)
        {
            Console.Write("\t\t\t\t\t\tEnter Your Name: ");
            string userName = Console.ReadLine();
            LibraryUser user = new LibraryUser(userName);

            Console.WriteLine($"\t\t\t\t\t\tWelcome {user.Name}");

            do
            {
                int choice = GetUserChoice("\t\t\t\t\t\tWhat would you like to do?\n" +
                                           "\t\t\t\t\t\t1- Borrow Books\n" +
                                           "\t\t\t\t\t\t2- Display Books\n" +
                                           "\t\t\t\t\t\t3- Exit\n",
                                           1, 3);

                if (choice == 3) break;

                switch (choice)
                {
                    case 1:
                        BorrowBook(user, library);
                        break;
                    case 2:
                        DisplayUserBooks(user, library);
                        break;
                }

            } while (true);
        }

        static void BorrowBook(LibraryUser user, Library library)
        {
            Console.WriteLine("\t\t\t\t\t\tEnter Book Details to Borrow:");
            Console.Write("\t\t\t\t\t\tTitle: ");
            string title = Console.ReadLine();
            Console.Write("\t\t\t\t\t\tAuthor: ");
            string author = Console.ReadLine();
            Console.Write("\t\t\t\t\t\tYear: ");
            int year = int.Parse(Console.ReadLine());

            Book book = new Book(title, author, year);
            user.BorrowBook(book, library);
        }

        static void DisplayUserBooks(LibraryUser user, Library library)
        {
            Console.WriteLine("\t\t\t\t\t\tBooks in the Library:");
            user.DisplayBook(library);
        }
    }
}
