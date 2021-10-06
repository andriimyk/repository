using NUnit.Tests2.Classes;
using NUnit.Tests2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests2.Abstracts
{
    public abstract class AbstractCar
    {
        private Body body;

        public Body Body {
            get { return body; }
            set {
                value.Name = value.Name + "x";
                body = value;
            } }

        public Engine Engine { get; set; }
        public List<Wheel> Wheels { get; set; }
        public CarCarcass CarCarcass { get; set; }
        public TypeOfCar TypeOfCar { get; set; }
        public Color Color { get; set; }

        public AbstractCar(Body body, Engine engine, List<Wheel> wheels, CarCarcass carCarcass, TypeOfCar typeOfCar, Color color)
        {
            Body = body;
            Engine = engine;
            Wheels = wheels;
            CarCarcass = carCarcass;
            TypeOfCar = typeOfCar;
            Color = color;
        }
        
    }
}
