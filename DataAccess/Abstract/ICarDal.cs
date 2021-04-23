using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetByCarId(int carId);
        List<Car> GetCarsByColorId(int colorid);
        List<Car> GetCarsByBrandId(int brandid);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

    }
}
