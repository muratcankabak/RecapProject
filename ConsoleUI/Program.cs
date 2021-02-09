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
            // GetAll,GetById,Insert,Update,Delete
            //BrandTest();
            //ColorTest();
            //CarTest();
        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //GetAll

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandName + " " + car.ModelName);
            }

            //GetById

            //Console.WriteLine(carManager.GetById(5).ModelName); 

            //Add

            //carManager.Add(new Car
            //{
            //    BrandId = 6,
            //    BrandName = "Mazda",
            //    ColorId = 1,
            //    ModelName = " 3 ",
            //    ModelYear = 2019,
            //    CarDescription = "Sedan Benzinli Otomatik",
            //    DailyPrice = 600
            //});

            //Update

            //var carToUpdate = carManager.GetById(10);
            //carToUpdate.ModelName = "3 ";
            //carManager.Update(carToUpdate);
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.BrandName + " " + car.ModelYear);
            //}

            //Delete

            //carManager.Delete(carManager.GetById(9));
        }
        private static void ColorTest()
        {
            //GetAll
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + " " + color.ColorName);
            }

            //GetById

            //var colorById = colorManager.GetById(2);
            //Console.WriteLine(colorById.ColorId + " " + colorById.ColorName);

            //Add
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}
            //Console.WriteLine("****** Ekleme Sonrası ******");
            //colorManager.Add(new Color
            //{
            //    ColorName = "Yeşil"
            //});
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}

            //Update
            //var colorToUpdate = colorManager.GetById(4);
            //colorToUpdate.ColorName = "Bordo";
            //colorManager.Update(colorToUpdate);
            //Console.WriteLine(colorManager.GetById(4).ColorName);

            //Delete
            //Color colorX = new Color() { ColorName = "Mor"};
            //colorManager.Add(colorX);
            //Console.WriteLine(colorX.ColorName + " eklendi."); //Tabloyu bozmamak için ekledik.
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}
            //colorManager.Delete(colorManager.GetById(10));
            //Console.WriteLine("Silme Sonrası");
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}
        }
        private static void BrandTest()
        {
            //GetAll
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + " " + brand.BrandName + " " + brand.Origin);
            }

            //GetById

            //var brandById = brandManager.GetById(2);
            //Console.WriteLine(brandById.BrandId + " " + brandById.BrandName);

            //Add

            //brandManager.Add(new Brand
            //{
            //    BrandName = "Honda",
            //    Origin = "Japon"
            //});
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}

            ////Update
            //var brandToUpdate = brandManager.GetById(6);
            //brandToUpdate.BrandName = "Mazda";
            //brandToUpdate.Origin = "Japonya";
            //brandManager.Update(brandToUpdate);
            //Console.WriteLine(brandManager.GetById(6).BrandName);

            //Delete
            //Brand brandX = new Brand() { BrandName = "Audi", Origin = "Almanya" };
            //Console.WriteLine(brandX.BrandName + " eklendi."); //Tabloyu bozmamak için ekledik.
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}
            //brandManager.Delete(brandManager.GetById(7));
            //Console.WriteLine("Silme Sonrası");
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}

        }

        //private static void AddTestWithoutCore()
        //{
        //    IBrandService brandManager = new BrandManager(new EfBrandDal());
        //    ICarService carManager = new CarManager(new EfCarDal());
        //    IColorService colorManager = new ColorManager(new EfColorDal());

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.BrandName);
        //    }
        //    Brand brand = new Brand { BrandName = "Dacia", Origin = "Romanya" };
        //    brandManager.Add(brand);
        //    carManager.Add(new Car
        //    {
        //        BrandId = brand.BrandId,
        //        ColorId = 2,
        //        BrandName = "Dacia",
        //        ModelName = "Sandero Stepway",
        //        ModelYear = 2007,
        //        CarDescription = "SUV Dizel Manuel",
        //        DailyPrice = 200
        //    });
        //    Console.WriteLine("************** Ekleme Sonrası **************");

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.BrandName);
        //    }
        //}
    }
}