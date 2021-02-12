using Core.Entities;
using Core.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEntityService<T> where T:class,IEntity,new()
    {
        IResult Add(T entity);
        IResult Delete(T entity);
        IDataResult<List<T>> GetAll();
        IDataResult<T> GetById(int id);
        IResult Update(T entity);
    }
}