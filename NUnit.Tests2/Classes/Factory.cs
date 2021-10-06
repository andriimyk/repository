using NUnit.Tests2.Abstracts;
using NUnit.Tests2.Enum;
using NUnit.Tests2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests2.Classes
{
    public class Factory : IFactory
    {
        public string factoryName;

        public Factory(string factoryName) {
            this.factoryName = factoryName;
        }
        public VolvoTruck Produce(VolvoTruckModel model, Color color)
        {
            return new VolvoTruck(model,color);
        }
        public ScaniaTruck Produce(ScaniaTruckModel model, Color color)
        {
            return new ScaniaTruck(model,color);
        }
    }
}
