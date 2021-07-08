using System.Collections.Generic;
using BookstoreAPI.Models;

namespace BookstoreAPI.Interfaces
{
    public interface IBookRepository
    {
        public List<Book> GetAllBooks();
        public Book GetBook(int id);

    }

}