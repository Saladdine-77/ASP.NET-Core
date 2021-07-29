using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore1.Models.Repositories
{
    public class AuthorRepository : IBookStoreRepository<Author>
    {
        IList<Author> authors;

        public AuthorRepository()
        {
            authors = new List<Author>()
            {
                new Author{Id = 1, Fullname="Khalid ESSADANI"},
                new Author{Id = 2, Fullname="Bill CAVIL"},
                new Author{Id = 3, Fullname="Kenzo KABAIO"},
            };
        }
        public void Add(Author entity)
        {
            entity.Id = authors.Max(b=>b.Id)+1;
            authors.Add(entity);
        }

        public void Delete(int id)
        {
            var author = Find(id);
            authors.Remove(author);
        }

        public Author Find(int id)
        {
            var author = authors.SingleOrDefault(au => au.Id == id);
            return author;
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(int id, Author entity)
        {
            var author = Find(id);
            author.Fullname = entity.Fullname;

        }
    }

}
