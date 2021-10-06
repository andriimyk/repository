using NUnit.Tests2.Enum;

namespace NUnit.Tests2.Classes
{
    public class CarCarcass
    {
        public TypeOfCar typeOfCar;
        public FactoryList factoryName;

        public CarCarcass (TypeOfCar typeOfCar, FactoryList factoryName)
        {
            this.typeOfCar = typeOfCar;
            this.factoryName = factoryName;
        }
    }
}