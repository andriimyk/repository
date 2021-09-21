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
        public string model;
        public string color;


        public VolvoTruck (VolvoTruckModel model, Color color, List<Wheel> wheel) : base(TypeOfCar.Truck, Factory.Volvo)
            {
            this.model = model.ToString();
            this.color = color.ToString();
            Body = new Body("Volvo Body");
            Engine = new Engine("Volvo Engine");
            Wheel = wheel;
            }
        

    }
}

