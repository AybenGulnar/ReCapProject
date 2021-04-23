using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarName = "Araba1", CarId=1,BrandId=1,ColorId=1,DailyPrice=1000,Description="Araba1",ModelYear=2000},
                new Car{CarName = "Araba2", CarId=2,BrandId=1,ColorId=3,DailyPrice=500,Description="Araba2",ModelYear=2002},
                new Car{CarName = "Araba3",CarId=3,BrandId=4,ColorId=4,DailyPrice=800,Description="Araba3",ModelYear=2005},
                new Car{CarName = "Araba4",CarId=4,BrandId=2,ColorId=2,DailyPrice=750,Description="Araba4",ModelYear=2010},
                new Car{CarName = "Araba5",CarId=5,BrandId=3,ColorId=5,DailyPrice=300,Description="Araba5",ModelYear=2016},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car Cartodelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(Cartodelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByCarId(int carId)
        {

            return _cars;
        }

        public List<Car> GetCarsByBrandId(int brandid)
        {
            return _cars.Where(c => c.BrandId == brandid).ToList();
        }

        public List<Car> GetCarsByColorId(int colorid)
        {
            return _cars.Where(c => c.ColorId == colorid).ToList();
        }

        public void Update(Car car)
        {
            Car UpdatedToCar = _cars.Where(c => c.CarId == c.CarId).SingleOrDefault();

            UpdatedToCar.BrandId = car.BrandId;
            UpdatedToCar.ColorId = car.ColorId;
            UpdatedToCar.DailyPrice = car.DailyPrice;
            UpdatedToCar.Description = car.Description;
            UpdatedToCar.ModelYear = car.ModelYear;
        }
    }
}
