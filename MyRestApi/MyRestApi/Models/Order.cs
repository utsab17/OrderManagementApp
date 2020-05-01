using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRestApi.Models
{
    public class Order
    {

        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public List<Item> ItemList { get; set; }
    }
}
