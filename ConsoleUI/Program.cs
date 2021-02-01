using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { CarId = 4, BrandId = 1, ColorId = 8, ModelYear = 2021, DailyPrice = 800, Description = "Lüks" };
            Car car2 = new Car { CarId = 2, BrandId = 4, ColorId = 1, ModelYear = 2016, DailyPrice = 500, Description = "Günlük Kullanıma Uygun" };

            ICarService carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("***************** GetAll ***************");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId + " " + car.Description);
            }
            carManager.Add(car1);
            Console.WriteLine("**************** Add *********************");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId + " " + car.Description);
            } 
            
            carManager.Update(car2);
            Console.WriteLine("**************** Update Orta Sınıf *********************");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId + " " + car.Description);
            }
            carManager.Delete(car2);
            Console.WriteLine("**************** Delete Günlük Kullanım *********************");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId + " " + car.Description);
            }
            ;
            Console.WriteLine("**************** BrandId = 4 ******************");
            foreach (var car in carManager.GetByBrandId(1))
            {
                Console.WriteLine(car.BrandId + " " + car.Description);
            }
            
            Console.WriteLine("**************** CarId = 4 ******************");
            Console.WriteLine(carManager.GetById(4).CarId + " " + carManager.GetById(4).Description);

        }
    }
}
