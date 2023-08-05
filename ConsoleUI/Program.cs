using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
            //Console.WriteLine("-------------------------------------------------------------------------");
            //Car car1 = new Car {Id=3,BrandId=3,ColorId=2,ModelYear=1998,DailyPrice=450,Description="1998 Model Kırmızı Volkswagen" };
            //carManager.Update(car1);
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
            //Console.WriteLine("-------------------------------------------------------------------------");
            //carManager.Add(new Car { BrandId=1,ColorId=3,DailyPrice=600,ModelYear=2002,Description="2002 Model Siyah BMW"});
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
            //Console.WriteLine("-------------------------------------------------------------------------");
            //foreach (var car in carManager.GetCarsByBrand(1))
            //{
            //    Console.WriteLine(car.Description);
            //}   
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} : {1}", car.CarName, car.Description);
            }
            Splice();
            foreach (var car in carManager.GetCarsByBrand(3)) 
            {
                Console.WriteLine("{0}  BrandId: {1}", car.CarName, car.BrandId);
            }
            Splice();
            foreach (var car in carManager.GetCarsByColor(1))
            {
                Console.WriteLine("{0}  ColorId: {1}", car.CarName, car.ColorId);
            }
            Splice();
            
        }

        private static void Splice()
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
        }
    }
}