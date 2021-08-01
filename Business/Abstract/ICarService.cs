﻿using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        List<Car> GetById(int categoryId);

        List<Car> GetAll();
    }
}