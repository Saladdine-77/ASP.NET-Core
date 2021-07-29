using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore1.Models.Repositories
{
    public class BookRepository : IBookStoreRepository<Book>
    {
        List<Book> books;
        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book
                {
                    Id = 1,
                    Title = "C# progamming Language",
                    Description ="None",
                    ImageUrl = "c.png",
                    Author = new Author{Id = 2}
                },
                new Book
                {
                    Id = 2,
                    Title = "Java progamming Language",
                    Description ="None",
                    ImageUrl = "java.png",
                    Author = new Author()
                },
                new Book
                {
                    Id = 3,
                    Title = "NLP progamming Language",
                    Description ="None",
                    ImageUrl = "nlp.png",
                    Author = new Author()
                },

            };
        }
        public void Add(Book entity)
        {
            entity.Id = books.Max(b => b.Id) + 1;
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = Find(id);
            books.Remove(book);
        }

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(b => b.Id == id);
            return book;
        }

        public IList<Book> List()
        {
            return books;
        }

        public void Update(int id, Book entity)
        {
            //finding the book to update
            var book = Find(id);
            //updating process
            book.Title = entity.Title;
            book.Description = entity.Description;
            book.Author = entity.Author;
            book.ImageUrl = entity.ImageUrl;


        }
    }

}
