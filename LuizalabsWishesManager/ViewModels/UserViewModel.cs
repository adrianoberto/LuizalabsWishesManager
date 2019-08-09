using System.Collections.Generic;
using System.Linq;

namespace LuizalabsWishesManager.ViewModels
{
    public class NewUserViewModel
    {   
        public string Name { get; set; }
        public string Email { get; set; }
    }


    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
