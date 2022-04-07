using System;
using System.IO;

namespace _07042022task
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library()
            {
                Name = "Elmin",
                Id = 1,
            };
            string path = @"C:\Users\Lenovo\Desktop\homework\07042022";
            Console.WriteLine("File name daxil edin :");
            string fileName = Console.ReadLine();
            if (!Directory.Exists(path + fileName))
            {
                Directory.CreateDirectory(path + fileName);
            }
            else
            {
                Console.WriteLine($"{fileName} adli file var");
            }
            if (!File.Exists(path + fileName + @"\Database.json"))
            {
                var createFile = File.Create(path + fileName + @"\Database.json");
                createFile.Close();
            }
            else
            {
                Console.WriteLine("Database.json  adli file var");
            }
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("Menu :");
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Get book by id");
                Console.WriteLine("3. Remove book");
                Console.WriteLine("0. Quit");
                Console.WriteLine("Secim Edin :");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "0":
                        menu = false;
                        break;
                    case "1":
                        int bookId = IntInput("Book Id daxil din :", "Book Id duzgun daxil edin :");
                        string bookName = StringInput("Book Name daxil edin :");
                        string bookAuthorName = StringInput("Book AuthorName Daxil Edin :");
                        double bookPrice = DoubleInput("Book Price daxil edin :", "Book Price duzgun daxil edin :");
                        Book book = new Book()
                        {
                            Id = bookId,
                            Name = bookName,
                            AuthorName = bookAuthorName,
                            Price = bookPrice,
                        };
                        library.AddBook(book);





                }
    }  
}
