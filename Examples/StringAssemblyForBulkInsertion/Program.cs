using System;
using System.Collections.Generic;
using System.Linq;

namespace ExampleStringAssemblyForBulkInsertion
{
    class Program
    {
        const int batchSize = 2;

        public static List<string> GetSqlsInBatches(List<Book> books)
        {
            var insertSql = "INSERT INTO [Book] (Name, Author, Isbn, ReleaseDate) VALUES ";
            var valuesSql = "('{0}', '{1}', '{2}', '{3}')";
            var sqlsToExecute = new List<string>();
            var numberOfBatches = (int)Math.Ceiling((double) books.Count / batchSize);
        
            for (int i = 0; i < numberOfBatches; i++)
            {
                var index = i * batchSize;

                var userToInsert = books.Skip(index).Take(batchSize);
                var valuesToInsert = userToInsert.Select(u => string.Format(valuesSql, u.Name, u.Author, u.Isbn, u.ReleaseDate));
                sqlsToExecute.Add(insertSql + string.Join(',', valuesToInsert));
            }
        
            return sqlsToExecute;
        }

        static void Main(string[] args)
        {
            var books = new List<Book>()
            {
                new Book() { Name = "Capitães da areia", Author = "Jorge Amado", Isbn = "8535914064", ReleaseDate = DateTime.Now },
                new Book() { Name = "Dona flor e seus dois maridos", Author = "Jorge Amado", Isbn = "8535911707", ReleaseDate = DateTime.Now },
                new Book() { Name = "Tieta do agreste", Author = "Jorge Amado", Isbn = "8535914048", ReleaseDate = DateTime.Now },
                new Book() { Name = "Gabriela, Cravo e Canela", Author = "Jorge Amado", Isbn = "8535920986", ReleaseDate = DateTime.Now },
                new Book() { Name = "Mar morto", Author = "Jorge Amado", Isbn = "8535911820", ReleaseDate = DateTime.Now }
            };

            foreach (var book in GetSqlsInBatches(books))
            {
                Console.WriteLine(book);
            }
        }
    }
}