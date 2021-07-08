using System.Collections.Generic;
using System.Linq;
using BookstoreAPI.Data;
using BookstoreAPI.Interfaces;
using BookstoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace BookstoreAPI.Repositories
 
{
    public class BookRepository : IBookRepository
    {
        private readonly BookstoreContext _context;
        public BookRepository (BookstoreContext context)
        {
            _context = context;
        }

        // public List<Book> books = new() {
        //     new Book { Id = 1, Title = "The Boy on the Train", Author = "Hawkins, Paula", PublicationYear = 2015, CallNumber = "F HAWKI"},
        //     new Book { Id = 2, Title = "Rogue Lawyer Twelve", Author = "Grisham, John", PublicationYear = 2015, CallNumber = "F GRISH"},
        //     new Book { Id = 3, Title = "After Me", Author = "Moyes, Jojo", PublicationYear = 2015, CallNumber = "F MOYES"},
        //     new Book { Id = 4, Title = "All the Dark We Cannot See", Author = "Doerr, Anthony", PublicationYear = 2014, CallNumber = "F DOERR"},
        //     new Book { Id = 5, Title = "Girls II", Author = "Cline, Emma", PublicationYear = 2016, CallNumber = "F CLINE"},
        //     new Book { Id = 6, Title = "The Martian", Author = "Weir, Andy", PublicationYear = 2011, CallNumber = "SF WEIR"},
        //     new Book { Id = 7, Title = "Me Before You", Author = "Moyes, Jojo", PublicationYear = 2012, CallNumber = "F MOYES"},
        //     new Book { Id = 8, Title = "Alexander Hamilton", Author = "Chernow, Ron", PublicationYear = 2004, CallNumber = "B HAMILTO A"},
        //     new Book { Id = 9, Title = "Before the Fall", Author = "Hawley, Noah", PublicationYear = 2016, CallNumber = "F HAWLE"}
        // };
        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetBook(int id)
        {
            return _context.Books.FirstOrDefault(x => x.Id == id);
        }

    }
}