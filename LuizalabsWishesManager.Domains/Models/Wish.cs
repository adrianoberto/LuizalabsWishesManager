using System;
using System.Collections.Generic;
using System.Text;

namespace LuizalabsWishesManager.Domains.Models
{
    public class Wish
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<Product> Products { get; set; }
    }
}
