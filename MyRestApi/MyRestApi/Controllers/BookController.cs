using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyRestApi.Database;
using MyRestApi.Models;
using MyRestApi.Services;

namespace MyRestApi.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _services;
        private readonly ApplicationDbContext _db;

        public BookController(IBookService services, ApplicationDbContext db)
        {
            _services = services;
            _db = db;

        }


        [HttpPost]
        [Route("AddBook")]
        public ActionResult<Book> AddBook(Book b)
        {
            _db.Book.Add(new Book
            {
                Name = b.Name,
                Category = b.Category,

            });

            _db.SaveChanges();
            return Ok();

           // var addedBook = _services.AddBook(b);
          //  if (addedBook == null) return NotFound();
           // return addedBook;
        }


        [HttpGet]
        [Route("GetBook")]
        public ActionResult<Dictionary<string, Book>> GetB()
        {
            var bookList = _services.GetBooks();
            if (bookList == null) return NotFound();
            return bookList;
        }
      
    }
}


      
 
