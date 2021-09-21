using NUnit.Tests2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnit.Tests2
{
    public interface IDescription
    {
        Body Body { get; set; }
        Engine Engine { get; set; }
        List<Wheel> Wheel { get; set; }// many WheelS
    }
}