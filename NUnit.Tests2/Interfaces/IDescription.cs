using NUnit.Tests2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnit.Tests2
{
    public interface IDescription
    {
        Body Body { set; }
        Engine Engine { set; }
        List<Wheel> Wheels { set; }// many WheelS
    }
}