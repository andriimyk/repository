using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Tests2.Enum;

namespace NUnit.Tests2.Classes
{
    public class VolvoTruck : Car, IDescription
    {

        public Body Body { get; set; }
        public Engine Engine { get; set; }
        public List<Wheel> Wheel { get; set; }

        public VolvoTruck (VolvoTruckModel model, Color color, List<Wheel> wheel) : base(TypeOfCar.Truck, Factory.Volvo)
            {
            Body.Name = "Volvo body";
            Engine.engineName = "Volvo";
            Wheel = wheel;
            }
    }
}

