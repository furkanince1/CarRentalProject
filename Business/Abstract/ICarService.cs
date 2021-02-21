using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByColorId(int id);
        IDataResult<List<Car>> GetByUnitPrice(decimal min,decimal max);
        IDataResult<Car> GetById(int carId);
        IResult Add(Car car);
        

    }
}
