﻿using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicModels;

namespace UserControls.Repository
{
    public interface IPricesOutSource
    {
        Prices GetPrices(Companies companies);
    }
}
