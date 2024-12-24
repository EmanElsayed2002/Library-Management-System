using Library_Management_System.Models;

namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWelcome to the Library System Management");
            Library library = new Library();
            int numberChoiceByUser = -1;
            do
            {
                Console.WriteLine("\t\t\t\t\t\tChoose Your Role please:\n" +
                 "\t\t\t\t\t\t\t1- Librarian\n\t\t\t\t\t\t\t2- Regular User");
                Console.Write("\t\t\t\t\t\tEnter Your Choice: ");
                numberChoiceByUser = int.Parse(Console.ReadLine());
            } while (numberChoiceByUser > 2 || numberChoiceByUser < 1);
            switch (numberChoiceByUser)
            {
                case 1:
                    LibrarianMethods(library);
                    break;
                case 2:
                    UserMethods(library);
                    break;
                default:
                    break;
            }
        }

        static void LibrarianMethods(Library library)
        {
            Console.Write("\t\t\t\t\t\tEnter the Librarian Name: ");
            string name = Console.ReadLine();
            Librarian librarian = new Librarian(name);
            Console.WriteLine($"\t\t\t\t\t\t\tWelcome {librarian.Name}");
            int LibrarianChoice = -1;
            char repeatedOperations ='N';
            do
            {
                do
                {
                    Console.WriteLine("\t\t\t\t\t\tPlease Enter What you Need To Do:\n" + "\t\t\t\t\t\t\t1- Add Books\n\t\t\t\t\t\t\t2- Remove Books\n\t\t\t\t\t\t\t3- Display Books");
                    Console.Write("\t\t\t\t\t\tEnter Your Choice: ");
                    LibrarianChoice = int.Parse(Console.ReadLine());
                } while (LibrarianChoice < 1 || LibrarianChoice > 3);

                switch (LibrarianChoice)
                {
                    case 1:
                        Console.WriteLine("\t\t\t\t\t\tEnter Book Details");
                        Console.Write("\t\t\t\t\t\tTitle: ");
                        string title = Console.ReadLine();
                        Console.Write("\t\t\t\t\t\tAuthor: ");
                        string author = Console.ReadLine();
                        Console.Write("\t\t\t\t\t\tYear: ");
                        int year = int.Parse(Console.ReadLine());
                        Book Book = new Book(title, author, year);
                        librarian.Add(Book, library);
                        break;
                    case 2:
                        Console.WriteLine("\t\t\t\t\t\tEnter Book Details");
                        Console.Write("\t\t\t\t\t\tTitle: ");
                        title = Console.ReadLine();
                        librarian.Remove(title, library);
                        break;
                    case 3:
                        Console.WriteLine("\t\t\t\t\t\tThe book list");
                        librarian.Display(library);
                        break;
                    default: Environment.Exit(0); break;
                }
                Console.WriteLine("\t\t\t\t\t\tDo You Want To Make Another Operation ? (Y/N)");
                Console.Write("\t\t\t\t\t\tEnter Your Choice: ");
                repeatedOperations = char.ToLower(char.Parse(Console.ReadLine()));
            } while (repeatedOperations == 'y');
            }


        static void UserMethods(Library library)
        {
            User user = new User();
            Console.WriteLine("Enter User Name: ");
            string name = Console.ReadLine();
            LibraryUser libUser = new LibraryUser(name);
            Console.WriteLine($"Welcome {libUser.Name}");
            int userChoice = -1;
            do
            {
                Console.WriteLine("\t\t\t\t\t\tPlease Enter What you Need To Do:\n" + "\t\t\t\t\t\t\t1- Borrow Books\n\t\t\t\t\t\t\t2- Display Books");
                Console.WriteLine("Please Enter Your Choice: ");
                userChoice = int.Parse(Console.ReadLine());

            } while (userChoice < 1 || userChoice > 2);

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("Enter Book Details to borrow");
                    Console.Write("Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Author: ");
                    string author = Console.ReadLine();
                    Console.Write("Year: ");
                    int year = int.Parse(Console.ReadLine());
                    Book Book = new Book(title, author, year);
                    user.BorrowBook(Book, library);
                    break;
                case 2:
                    Console.WriteLine("The book list");
                    user.DisplayBook(library);
                    break;
                default: Environment.Exit(0); break;
            }



        }

    }
}
