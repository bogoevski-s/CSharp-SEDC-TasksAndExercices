using System;

namespace Class_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[2]
           {
                new Book("Robin Sharma", "The monk who sold his ferrari", 2004),
                new Book("Greta Gabro", "Anna Karenina", 1935)

           };
            int addBookCounter = books.Length;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nBook Library \n");
                Console.ResetColor();
                Console.WriteLine("1.Add new book to library\n2.Show all books\n3.Search\n4.Exit\n");
                string userInput = Console.ReadLine();
                bool userInputParsed = int.TryParse(userInput, out int userInputNumber);
                if(!userInputParsed || userInputNumber > 4 || userInputNumber < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input!! Select numberic value from 1-4");
                    Console.ResetColor();
                    continue;
                }

                if (userInputNumber == 1)
                {
                    while (true)
                    {
                        addBookCounter++;

                        Console.WriteLine("\nPlease enter author:");
                        string authorInput = Console.ReadLine();

                        Console.WriteLine("\nPlease enter title of the book:");
                        string titleInput = Console.ReadLine();

                        Console.WriteLine("\nPlease enter year of the book:");
                        string yearInput = Console.ReadLine();
                        bool yearInputParsed = int.TryParse(yearInput, out int yearInputNumber);

                        if (!yearInputParsed)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nWrong input year. Please enter numeric value\n");
                            Console.ResetColor();
                            addBookCounter = books.Length;
                            continue;
                        }
                    
                        Book newBook = new Book(authorInput, titleInput, yearInputNumber);

                        Array.Resize(ref books, addBookCounter);
                        books[addBookCounter - 1] = newBook;

                        Console.WriteLine("\n1.Add new book\n2.Return to main menu\n");
                        string userInputBook = Console.ReadLine();
                        bool userInputBookParsed = int.TryParse(userInputBook, out int userInputBookNumber);

                        if(!userInputBookParsed || userInputBookNumber < 1 || userInputBookNumber > 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nWrong input!!! Please select 1 or 2\n");
                            Console.ResetColor();
                            continue;
                        }
                        else
                        {
                            if (userInputBookNumber == 1) continue;
                            else if (userInputBookNumber == 2) break;
                        }
                    }

                }
                else if (userInputNumber == 2)
                {
                    while (true)
                    {
                        ShowAllBooks(books);
                        Console.WriteLine("\n\n1.Return to main menu\n2.Exit App\n");
                        string userInputBook = Console.ReadLine();
                        bool userInputBookParsed = int.TryParse(userInputBook, out int userInputInt);
                        if (!userInputBookParsed || userInputInt > 3 || userInputInt < 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nWrong input!!! Please select 1 or 2\n");
                            Console.ResetColor();
                            continue;
                        }
                        else
                        {
                            if (userInputInt == 1) break;
                            else if (userInputInt == 2) return;
                        }
                    }

                }
                else if(userInputNumber == 3)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter Title or author to search:");
                        string searchInput = Console.ReadLine();
                        
                        ShowAllBooks(SearchBooks(books, searchInput));

                        Console.WriteLine("\n\n1.Add new book\n2.Return to main menu\n3.Exit App\n");
                        string userInputBook = Console.ReadLine();
                        bool userInputBookParsed = int.TryParse(userInputBook, out int userInputInt);
                        if (!userInputBookParsed || userInputInt > 3 || userInputInt < 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nWrong input!!! Please select 1 - 3\n");
                            Console.ResetColor();
                            continue;
                        }
                        else
                        {
                            if (userInputInt == 1) continue;
                            else if (userInputInt == 2) break;
                            else if (userInputInt == 3) return;
                        }
                    }
                    
                }
                else if (userInputNumber == 4)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nWrong input!!. Please enter numeric value\n");
                    Console.ResetColor();
                    addBookCounter = books.Length;
                    continue;
                }
            }
        }

        static void ShowAllBooks(Book[] books)
        {
            foreach (Book book in books)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{book.Title}| by {book.Author} | release year:{book.Year}\n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{book.BookSummary()}\n{book.AuthorInfo()}\n");
                Console.ResetColor();
            }
        }

        static Book[] SearchBooks(Book[] books, string bookTitle)
        {
       
            Book[] searchedBook = new Book[1];
            foreach (Book book in books)
            {
                if(bookTitle.ToLower() == book.Title.ToLower())
                {
                    searchedBook[0] = book;
                }
            }
            foreach (Book book in books)
            {
                if (bookTitle.ToLower() == book.Author.ToLower())
                {
                    searchedBook[0] = book;
                }
            }
            return searchedBook;
        }
    }
    
}
