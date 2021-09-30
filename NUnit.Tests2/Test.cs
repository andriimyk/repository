using NUnit.Framework;
using NUnit.Tests2.Abstracts;
using NUnit.Tests2.Classes;
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
            Wheel one = new Wheel(1);
            Wheel two = new Wheel(2);
            Wheel three = new Wheel(3);
            Wheel four = new Wheel(4);

            List<Wheel> wheels = new List<Wheel> { one, two, three, four };
            VolvoTruck VolvoCar = new VolvoTruck(Enum.VolvoTruckModel.R420, Enum.Color.Orange, wheels);

            //still need to create wheels separately and fasten to the cart
            //Factory is not ready
            //
            /*
             * IFactory factory = new CarFactory();
             * List<ICar> cars = new List <ICar>()
             * cars.Add(factory.Produce(carType.Truck, carTypeModel.Volvo.R420, Color.Orange));
             * cars.Add(factory.Produce(carType.Truck, carTypeModel.Scania.___, Color.Blue));
             * Assert.IsTrue(cars.First().Wheels.Count==4);
             * Assert.IsTrue(car.First().GetType()==typeof(VolvoTruck));
             * Assert.IsTrue(cars.First().Wheels.Count==4);
             * Assert.IsTrue(car.First().GetType()==typeof(ScaniaTruck));
             * 
             * 
             */
        }

    }
}
