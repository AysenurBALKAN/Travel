﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEntityLayer.Concrete;

namespace TDataAccesLayer.Abstract
{
  public  interface IGuideDal:IGenericDal<Guide>
    {

        void ChangetoTrue(int id);
        void ChangetoFalse(int id);
    }
}
