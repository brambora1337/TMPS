using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    interface ICarRepository
    {
        Car GetCarById(int id);
        void InsertCar(Car car);
        void RemoveCarById(int id);
    }
}
