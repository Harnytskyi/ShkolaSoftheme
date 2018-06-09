using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConstructor
{
    struct Car
    {
        public Color _color { get; }
        public Engine _engine { get; set; }
        public Transmission _transmission { get; }

        public Car(Color color, Engine engine, Transmission transmission)
        {
            _color = color;
            _engine = engine;
            _transmission = transmission;
        }
        public override string ToString()
        {
            return String.Format("Car color is {0}. Engine is {1}. Transmission type is {2}", _color.ToString(), _engine.ToString(), _transmission.ToString());
        }
    }
}
