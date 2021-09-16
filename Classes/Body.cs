using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnit.Tests2
{
    public class Body : BaseDetail
    {
        public Body(string name) : base(name, DetailType.Body)
        {
            name = "Body";
        }
    }
}