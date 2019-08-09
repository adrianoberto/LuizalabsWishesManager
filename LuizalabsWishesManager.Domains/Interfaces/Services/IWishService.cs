﻿using LuizalabsWishesManager.Domains.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LuizalabsWishesManager.Domains.Services
{
    public interface IWishService : IServiceBase<Wish>
    {
        Wish GetById(int wishId, int page, int pageSize);
        void Delete(int userId, int productId);
    }
}
