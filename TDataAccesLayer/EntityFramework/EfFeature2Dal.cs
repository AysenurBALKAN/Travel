﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDataAccesLayer.Abstract;
using TDataAccesLayer.Repository;
using TEntityLayer.Concrete;

namespace TDataAccesLayer.EntityFramework
{
   public class EfFeature2Dal : GenericRepository<Feature2>, IFeature2Dal
    {
    }
}
