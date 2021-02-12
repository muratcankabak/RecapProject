using Core.Utilities.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService : IEntityService<Customer>
    {
        IDataResult<List<CustomerUserDto>> GetCustomerDetails();
    }
}