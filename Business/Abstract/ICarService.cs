﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrand(int brandId);
        List<Car> GetCarsByColor(int colorId);

        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    } 
}
