using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTOs;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using Business.Constants;
using Core.CrossCuttingConcerns.Validation;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            //if (car.ModelName.Length > 1)
            //{
            //    if (car.DailyPrice > 0)
            //    {
            //        _carDal.Add(car);
            //        return new SuccessResult(Messages.Success);
            //    }
            //    else return new ErrorResult(Messages.Error);
            //}
            //else return new ErrorResult(Messages.Error);

            //ValidationTool.Validate(new CarValidator(),car);

            _carDal.Add(car);
            return new SuccessResult(Messages.Success);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.Success);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.Success);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == carId), Messages.Success);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.Success);
        }

        public IResult Update(Car car)
        {
            if (car.ModelName.Length > 1)
            {
                if (car.DailyPrice > 0)
                {
                    _carDal.Update(car);
                    return new SuccessResult(Messages.Success);
                }
                else return new ErrorResult(Messages.Error);
            }
            else return new ErrorResult(Messages.Error);
        }
    }
}