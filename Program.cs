using OOPFundamentals.DAL;
using OOPFundamentals.Entities;
using OOPFundamentals.Service;
using System;

namespace OOPFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileManager = new FileManager("./Docs");
            var searchManager = new FileManagerService(fileManager);

            var patent = new Book
            {
                ISBN = "978-3-16-148410-0",
                NumberOfPages = 150,
                Publisher = "Book World",
                Title = "Harry Potter",
                Authors = new[] { "J. K. Rowling" },
                DatePublished = DateTime.Now,
            };

            searchManager.WriteCard("1", patent);
            var patentCardInfo = searchManager.Search<Book>("1");
            foreach (var info in patentCardInfo)
            {
                Console.WriteLine(info);
            }
        }
    }
}
