using NUnit.Framework;
using NUnit.Tests2.Abstracts;
using NUnit.Tests2.Classes;
using NUnit.Tests2.Enum;
using NUnit.Tests2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnit.Tests2
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestOne()
        {

        }
        [Test]
        public void TestTwo()
        {

            Car car = new Car(new List<DetailType>());
            GreenCar greenCar = new GreenCar(new List<DetailType>());
            var baseCar = (Machine)new Car(new List<DetailType>());
           
        }

        class Car : Machine
        {

            public Car(List<DetailType> details) : base(details)
            {   
            }    
        }

        class GreenCar : Machine
        {
            public string Color = "green";
            public GreenCar(List<DetailType> details) : base(details)
            {
            }
        }

        [Test]
        public void TestThree()
        {

            Factory factory = new Factory("Some factory");

            CarCarcass volvoCarcass = new CarCarcass(TypeOfCar.Truck, FactoryList.Volvo);

            List<ICar> cars = new List<ICar>();
            cars.Add(factory.Produce(VolvoTruckModel.R420, Color.Green));
            cars.Add(factory.Produce(ScaniaTruckModel.R420, Color.Orange));
            Assert.IsTrue(cars.First().Wheels.Count == 4);
            Assert.IsTrue(cars.First().GetType()==typeof(VolvoTruck));
            Assert.IsTrue(cars[1].Body.Name == "Scania body");
            Assert.IsTrue(cars[1].Color.ToString() == "Orange");

        }

    }
}
