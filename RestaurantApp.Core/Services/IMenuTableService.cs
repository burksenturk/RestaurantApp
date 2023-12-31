﻿using RestaurantApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Core.Services
{
    public interface IMenuTableService : IGenericService<MenuTable>
    {
        int TMenuTableCount();
    }
}
