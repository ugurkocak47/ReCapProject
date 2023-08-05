using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car {Id=1,BrandId=1,ColorId=2,ModelYear=1998,DailyPrice=300,Description="1998 Model Kırmızı BMW" },
                new Car {Id=2,BrandId=1,ColorId=1,ModelYear=2016,DailyPrice=550,Description="2016 Model Beyaz BMW" },
                new Car {Id=3,BrandId=2,ColorId=2,ModelYear=1998,DailyPrice=300,Description="1998 Model Kırmızı Audi" },
                new Car {Id=4,BrandId=2,ColorId=3,ModelYear=2005,DailyPrice=400,Description="2005 Model Siyah Audi" },
                new Car {Id=5,BrandId=3,ColorId=1,ModelYear=2005,DailyPrice=350,Description="2005 Model Beyaz Volkswagen" },
            };
        }

        public void Add(Car car)
        {
            car.Id = _cars.Count + 1;
            _cars.Add(car);
            Console.WriteLine("Araba eklendi (Id =" + car.Id + ")");
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
            Console.WriteLine("Araba silindi (Id= " + car.Id + ")");

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrand(int brandId)
        {
            return _cars.Where(c=>c.BrandId==brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear   = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            Console.WriteLine("Araba güncellendi (Id =" + car.Id + ")");
        }
    }
}
