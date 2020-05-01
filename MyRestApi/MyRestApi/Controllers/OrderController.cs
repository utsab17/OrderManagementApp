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
    [Route("v2/")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IBookService _services;
        private readonly ApplicationDbContext _db;

        public OrderController(IBookService services, ApplicationDbContext db)
        {
            _services = services;
            _db = db;

        }

        [HttpPost]
        [Route("AddOrder")]
        public ActionResult<Order> AddBook(Order o)
        {

            _db.Order.Add(new Order
            {
                OrderId = o.OrderId,
                CustomerId = o.CustomerId,
                ItemList = o.ItemList

            });

            _db.SaveChanges();
            return Ok();

        }
    }
}