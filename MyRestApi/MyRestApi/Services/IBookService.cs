using MyRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRestApi.Services
{
    public interface IBookService
    {
        Book AddBook(Book b);

        Dictionary<string, Book> GetBooks();
    }
}
