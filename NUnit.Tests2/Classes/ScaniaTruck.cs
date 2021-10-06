using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Tests2.Abstracts;
using NUnit.Tests2.Enum;

namespace NUnit.Tests2.Classes
{
    public class ScaniaTruck : Car
    {
        public ScaniaTruckModel model;

        public ScaniaTruck(ScaniaTruckModel model) : base(new Body("Scania body"), new Engine("Scania engine"), new List<Wheel> { new Wheel(1), new Wheel(2), new Wheel(3), new Wheel(4) }, new CarCarcass(TypeOfCar.Truck,FactoryList.Scania), TypeOfCar.Truck, Color.Blue)
            {
            
            }

        public ScaniaTruck(ScaniaTruckModel model, Color color) : base(new Body("Scania body"), new Engine("Scania engine"), new List<Wheel> { new Wheel(1), new Wheel(2), new Wheel(3), new Wheel(4) }, new CarCarcass(TypeOfCar.Truck, FactoryList.Scania), TypeOfCar.Truck, color)
        {

        }
    }
}

