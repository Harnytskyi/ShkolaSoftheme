using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConstruct
{
    public static class CarConstructor
    {
        public static Car Construct(Engine engine, Color color, Transmission transmission)
        {
            return new Car(color, engine, transmission);
        }
        public static Car Reconstruct(Car car, Engine engine)
        {
            car._engine = engine;
            return car;
        }
    }
}
