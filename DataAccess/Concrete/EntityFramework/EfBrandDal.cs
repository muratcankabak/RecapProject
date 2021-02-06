using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand brand)
        {
            using (RecapProjectDBContext context = new RecapProjectDBContext())
            {
                var addedEntity = context.Entry(brand);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            };
        }

        public void Delete(Brand brand)
        {
            using (RecapProjectDBContext context = new RecapProjectDBContext())
            {
                var deletedEntity = context.Entry(brand);
                deletedEntity.State = EntityState.Added;
                context.SaveChanges();
            };
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (RecapProjectDBContext context = new RecapProjectDBContext())
            {
                return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList();
            };
        }

        public void Update(Brand brand)
        {
            using (RecapProjectDBContext context = new RecapProjectDBContext())
            {
                var updatedEntity = context.Entry(brand);
                updatedEntity.State = EntityState.Added;
                context.SaveChanges();
            };
        }
    }
}
