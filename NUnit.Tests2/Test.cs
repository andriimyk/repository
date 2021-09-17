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

            List<Wheel> wheels = new List<Wheel>(6);
       
            VolvoTruck VolvoCar = new VolvoTruck(Enum.VolvoTruckModel.R420, Enum.Color.Orange, wheels);
        }

    }
}
