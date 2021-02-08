using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddTestWithoutCore();
            //BrandTest();
            CarManager carManager = new CarManager(new EfCarDal());
            var car = carManager.GetById(3);
            Console.WriteLine(car.CarId +" "+ car.BrandName +" "+ car.ModelName);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void AddTestWithoutCore()
        {
            IBrandService brandManager = new BrandManager(new EfBrandDal());
            ICarService carManager = new CarManager(new EfCarDal());
            IColorService colorManager = new ColorManager(new EfColorDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandName);
            }
            Brand brand = new Brand { BrandName = "Mercedes" };
            brandManager.Add(brand);
            carManager.Add(new Car
            {
                BrandId = brand.BrandId,
                ColorId = 8,
                BrandName = "Mercedes",
                ModelName = "CLK 200 Komp.",
                ModelYear = 2007,
                CarDescription = "Coupe Benzinli Otomatik",
                DailyPrice = 250
            });
            Console.WriteLine("************** Ekleme Sonrası **************");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandName);
            }
        }
    }
}