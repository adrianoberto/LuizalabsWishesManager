using System.Collections.Generic;
using System.Linq;

namespace LuizalabsWishesManager.ViewModels
{
    public class NewProductViewModel
    {
        public string Name { get; set; }
    }

    public class ProductViewModel
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
    }

    public class ProductWishViewModel
    {
        public int IdProduct { get; set; }        
    }
}
