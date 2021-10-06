using NUnit.Tests2.Enum;
using System.Collections.Generic;

namespace NUnit.Tests2.Classes
{
    public interface ICar{
        CarCarcass CarCarcass { get;  set; }
        TypeOfCar TypeOfCar { get; set; }
        Color Color { get; set; }
        Body Body { get; set; }
        Engine Engine { get; set; }
        List<Wheel> Wheels { get; set; }
    }
}