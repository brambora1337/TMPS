using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy
{
    class CarRepository : ICarRepository
    {
        private readonly List<Car> _dbCars = new List<Car>()
        {
            new Car(7, "BMW", "M2 2018"),
            new Car(11, "BMW", "X6 2020"),
            new Car(23, "Mercedes", "C63 AMG 2017"),
            new Car(44, "Mercedes", "CLS 63 AMG 2015"),
            new Car(57, "Audi", "RS7 2020"),
            new Car(101, "Audi", "Q8 2021"),
        };

        public Car GetCarById(int id)
        {
            Console.WriteLine("Getting car by id");
            Thread.Sleep(2000);

            return _dbCars.FirstOrDefault(x => x.Id == id);
        }

        public void InsertCar(Car car)
        {
            Console.WriteLine("Adding car");
            Thread.Sleep(2000);

            _dbCars.Add(car);
        }

        public void RemoveCarById(int id)
        {
            Console.WriteLine("Removing car");
            Thread.Sleep(2000);

            var car = _dbCars.Find(x => x.Id == id);
            _dbCars.Remove(car);
        }
    }
}
