using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Tests2.Abstracts;
using NUnit.Tests2.Enum;

namespace NUnit.Tests2.Classes
{
    public class VolvoTruck : Car
    {
        public VolvoTruckModel model;

        public VolvoTruck (VolvoTruckModel model) : base(new Body("Volvo body"), new Engine("Volvo engine"), new List<Wheel> { new Wheel(1), new Wheel(2), new Wheel(3), new Wheel(4) }, new CarCarcass(TypeOfCar.Truck,FactoryList.Volvo), TypeOfCar.Truck, Color.Blue)
            {
            
            }

        public VolvoTruck (VolvoTruckModel model, Color color) : base(new Body("Volvo body"), new Engine("Volvo engine"), new List<Wheel> { new Wheel(1), new Wheel(2), new Wheel(3), new Wheel(4) }, new CarCarcass(TypeOfCar.Truck, FactoryList.Volvo), TypeOfCar.Truck, color)
        {

        }
    }
}

