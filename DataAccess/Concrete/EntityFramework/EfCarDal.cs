using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,RecapProjectDBContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RecapProjectDBContext context = new RecapProjectDBContext())
            {
                var result = from c in context.Cars
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 BrandName = c.BrandName,
                                 ModelName = c.ModelName,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Origin = b.Origin /* Ödev için bakan arkadaşlara ,
                                      Ben ModelName'i Car classına verdiğim için
                                      Brand tablosuna da join olmak adına Origin kolonunu ekledim.
                                      sizde böyle bir kolon olmaması gerekiyor.*/
                             };
                return result.ToList();
            }
        }
    }    
}
