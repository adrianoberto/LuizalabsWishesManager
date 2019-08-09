using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LuizalabsWishesManager.ViewModels
{
    public class NewWishViewModel
    {
        [Required]
        [Display(Name = "idProduct")]
        public int Id { get; set; }
    }

    public class WishViewModel
    {
        public List<ProductViewModel> Products { get; set; }
    }
}
