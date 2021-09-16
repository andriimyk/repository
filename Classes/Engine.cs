using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnit.Tests2
{
    public class Engine : BaseDetail
    {
        public string engineName;
        public Engine(string engineName) : base("Truck engine", DetailType.Engine)
        {
            this.engineName = engineName;
        }
    }
}