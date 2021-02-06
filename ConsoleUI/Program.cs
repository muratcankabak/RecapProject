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