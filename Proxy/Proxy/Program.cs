using Proxy;
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarRepository repo = new CarCachedRepository(new CarRepository());

            var car1 = repo.GetCarById(44);
            var car2 = repo.GetCarById(23);
            var car3 = repo.GetCarById(57);
            var car4 = repo.GetCarById(23);

        }
    }
}
