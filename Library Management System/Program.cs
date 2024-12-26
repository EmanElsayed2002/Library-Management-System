namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            int userChoice = -1;
                Console.WriteLine("Welcome to our Library");
                Console.WriteLine("----------------------");
            char ch = 'n';
            do
            {
                do
                {
                    Console.WriteLine("1.Add Book\n2.Add User\n3.Display Available Books\n4.Display Members\n5.BorrowBooks\n6.Return Book\n7.Exit");
                    Console.Write("Enter your Choice: ");
                    userChoice = int.Parse(Console.ReadLine());
                } while (userChoice < 1 || userChoice > 6);
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("----Adding Your Book----");
                        Book book = new Book();
                        Console.Write("Book Title: ");
                        book.Title = Console.ReadLine();
                        Console.Write("Book Author: ");
                        book.Author = Console.ReadLine();
                        library.AddBook(book);
                        break;
                    case 2:
                        Console.WriteLine("----Adding Your User----");
                        Member member = new Member();
                        Console.Write("Member Name: ");
                        member.Name = Console.ReadLine();
                        Console.Write("Member Author: ");
                        member.UserID = Console.ReadLine();
                        library.AddMember(member);
                        break;
                    case 3:
                        Console.WriteLine("----Display Available Books----");
                        library.DisplayAvailableBooks();
                        break;
                    case 4:
                        Console.WriteLine("----Display Members----");
                        library.DisplayMembers();
                        break;
                    case 5:
                        Console.WriteLine("----Borrow Books----");
                        Book _book = new Book();
                        Console.Write("Enter usenameId: ");
                        string usenameId = Console.ReadLine();
                        Console.Write("Book Title: ");
                        string _title = Console.ReadLine();
                        library.BorrowBook(_title, usenameId);
                        break;
                    case 6:
                        Console.WriteLine("----Return Book----");
                        Console.Write("Enter usenameId: ");
                        string _usenameId = Console.ReadLine();
                        Console.Write("Book Title: ");
                        string title = Console.ReadLine();
                        library.ReturnBook(title, _usenameId);
                        break;
                    default:
                        Console.WriteLine("GoodBye!!");
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Do Tou need Another Process(Y/N)");
                ch = char.ToLower(char.Parse(Console.ReadLine()));
            } while (ch == 'y');
        }
    }
}
