using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnit.Tests2
{
    public class Wheel : BaseDetail
    {
        public int wheelNum;
        public Wheel(int wheelNum) : base("Wheel", DetailType.Wheel)
        {
            this.wheelNum = wheelNum;
        }
    }
}