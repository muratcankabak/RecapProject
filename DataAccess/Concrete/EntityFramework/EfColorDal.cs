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
    public class EfColorDal : IColorDal
    {
        public void Add(Color color)
        {
            using (RecapProjectDBContext context = new RecapProjectDBContext())
            {
                var addedEntity = context.Entry(color);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            };
        }

        public void Delete(Color color)
        {
            using (RecapProjectDBContext context = new RecapProjectDBContext())
            {
                var deletedEntity = context.Entry(color);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            };
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (RecapProjectDBContext context = new RecapProjectDBContext())
            {
                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color color)
        {
            using (RecapProjectDBContext context = new RecapProjectDBContext())
            {
                var updatedEntity = context.Entry(color);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            };
        }
    }
}
