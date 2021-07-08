using System.Collections.Generic;
using System.Linq;
using BookstoreAPI.Interfaces;
using BookstoreAPI.Models;
using BookstoreAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _db;
        public BooksController (IBookRepository db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            // return books.GetAllBooks();
            return _db.GetAllBooks();
        }

        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _db.GetBook(id);
        }

    }



}