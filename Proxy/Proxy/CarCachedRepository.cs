using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class CarCachedRepository : ICarRepository
    {
        private readonly CarRepository _dbRepo;
        private readonly Dictionary<int, Car> _cache;

        public CarCachedRepository(CarRepository dbRepo)
        {
            _dbRepo = dbRepo;
            _cache = new Dictionary<int, Car>();
        }
        public Car GetCarById(int id)
        {
            Car car = null;

            _cache.TryGetValue(id, out car);

            if (car == null)
            {
                car = _dbRepo.GetCarById(id);
                if (car != null)
                    _cache.Add(car.Id, car);
            }
            else
                Console.WriteLine("Car extracted from cache");

            return car;
        }

        public void InsertCar(Car car)
        {
            _dbRepo.InsertCar(car);
            _cache.Add(car.Id, car);
        }

        public void RemoveCarById(int id)
        {
            _dbRepo.RemoveCarById(id);
            _cache.Remove(id);
        }
    }
}
