using NUnit.Tests2.Classes;
using NUnit.Tests2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests2.Abstracts
{
    public class Car : AbstractCar, ICar 
    {

        public Car(Body body, Engine engine, List<Wheel> wheels, CarCarcass carCarcass, TypeOfCar typeOfCar, Color color) 
            : base (body, engine, wheels, carCarcass, typeOfCar, color)
        {
        }


    }
}



