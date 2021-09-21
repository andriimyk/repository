using NUnit.Tests2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests2.Classes
{
    public abstract class Car : IDescription
    {
        public TypeOfCar TypeOfCar { get; set; }
        public Factory Factory { get; set; }
        public Body Body { get; set; }
        public Engine Engine { get; set; }
        public List<Wheel> Wheel { get; set; }

        public Car(TypeOfCar typeOfCar, Factory factory)
        {
            TypeOfCar = typeOfCar;
            Factory = factory;
        }


    }
}
