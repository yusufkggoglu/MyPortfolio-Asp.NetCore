﻿using MyPortfolio.DataAccess.Abstract;
using MyPortfolio.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.DataAccess.Concrete.EntityFramework
{
    public class EfPortfolioDal : EfEntityRepositoryBase<Portfolio , MyPortfolioContext> , IPortfolioDal
    {
    }
}
