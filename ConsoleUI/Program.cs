﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

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
            CarTest();
            //CarsByDto();
            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //UserManager userManager = new UserManager(new EfUserDal());
            //RentalAddTest();

            //UserTest(userManager);
            //CustomerTest(customerManager);

        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            rentalManager.Add(new Rental { CarId = 10, CustomerId = 2, RentDate = new DateTime(2021, 02, 05), ReturnDate = new DateTime(2021, 02, 10) });
        }

        private static void CustomerTest(CustomerManager customerManager)
        {
            List<Customer> customers = new List<Customer>
                {
                new Customer{ UserId = 1, CompanyName = "ABC Yayın Evi" },
                new Customer{ UserId = 2, CompanyName = "DEF Telekomünikasyon" },
                new Customer{ UserId = 3, CompanyName = "XYZ Lojistik" },
                };
            foreach (var customer in customers)
            {
                customerManager.Add(customer);
            }
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.UserId + " " + customer.CompanyName);
            }
        }

        private static void UserTest(UserManager userManager)
        {
            
            List<User> users = new List<User>
                {
                new User{ FirstName = "Oğuz", LastName = "Atay", Email = "o.a@abc.com", Password = "hashedpw1"},
                new User{ FirstName = "Peyami", LastName = "Safa", Email = "p.s@abc.com", Password = "hashedpw2"},
                new User{ FirstName = "Yusuf", LastName = "Atılgan", Email = "y.a@abc.com", Password = "hashedpw3"}
                };
            foreach (var user in users)
            {
                userManager.Add(user);
            }
        }

        private static void CarsByDto()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.BrandName + " => " + car.ModelName + " => " + car.ColorName + " => " + car.Origin + " => " + car.DailyPrice);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //GetAll
            var result = carManager.GetAll();
            foreach (var car in result.Data)
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

            //    //Update

            //    //var carToUpdate = carManager.GetById(10);
            //    //carToUpdate.ModelName = "3 ";
            //    //carManager.Update(carToUpdate);
            //    //foreach (var car in carManager.GetAll())
            //    //{
            //    //    Console.WriteLine(car.BrandName + " " + car.ModelYear);
            //    //}

            //    //Delete

            //    //carManager.Delete(carManager.GetById(9));
        }
        private static void ColorTest()
        {
            //GetAll
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            foreach (var color in result.Data)
            {
                Console.WriteLine(color.ColorId + " " + color.ColorName);
            }

            //    //GetById

            //    //var colorById = colorManager.GetById(2);
            //    //Console.WriteLine(colorById.ColorId + " " + colorById.ColorName);

            //    //Add
            //    //foreach (var color in colorManager.GetAll())
            //    //{
            //    //    Console.WriteLine(color.ColorName);
            //    //}
            //    //Console.WriteLine("****** Ekleme Sonrası ******");
            //    //colorManager.Add(new Color
            //    //{
            //    //    ColorName = "Yeşil"
            //    //});
            //    //foreach (var color in colorManager.GetAll())
            //    //{
            //    //    Console.WriteLine(color.ColorName);
            //    //}

            //    //Update
            //    //var colorToUpdate = colorManager.GetById(4);
            //    //colorToUpdate.ColorName = "Bordo";
            //    //colorManager.Update(colorToUpdate);
            //    //Console.WriteLine(colorManager.GetById(4).ColorName);

            //    //Delete
            //    //Color colorX = new Color() { ColorName = "Mor"};
            //    //colorManager.Add(colorX);
            //    //Console.WriteLine(colorX.ColorName + " eklendi."); //Tabloyu bozmamak için ekledik.
            //    //foreach (var color in colorManager.GetAll())
            //    //{
            //    //    Console.WriteLine(color.ColorName);
            //    //}
            //    //colorManager.Delete(colorManager.GetById(10));
            //    //Console.WriteLine("Silme Sonrası");
            //    //foreach (var color in colorManager.GetAll())
            //    //{
            //    //    Console.WriteLine(color.ColorName);
            //    //}
        }
        private static void BrandTest()
        {
            //GetAll
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll().Data;
            foreach (var brand in result)
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