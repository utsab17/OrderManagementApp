using Microsoft.EntityFrameworkCore;
using MyRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRestApi.Database
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Book> Book { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<Item> Item { get; set; }





    }
}
