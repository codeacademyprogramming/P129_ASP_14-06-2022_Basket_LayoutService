﻿using P129Allup.ViewModels.BasketViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P129Allup.Interfaces
{
    public interface ILayoutService
    {
        Task<List<BasketVM>> GetBasket();
    }
}
