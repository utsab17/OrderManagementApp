using MyRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRestApi.Services
{
    public class BookService : IBookService
    {
        private readonly Dictionary<string, Book> _bookList;

        public BookService()
        {

            _bookList = new Dictionary<string, Book>();

        }
        public Book AddBook(Book b)
        {
            _bookList.Add(b.Name, b);
            return b;

        }

        public Dictionary<string, Book> GetBooks()
        {
            return _bookList;
        }
    }
}
