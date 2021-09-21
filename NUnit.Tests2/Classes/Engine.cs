using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnit.Tests2
{
    public class Engine : BaseDetail
    {
        public string engineFactory;
        public Engine(string engine) : base("Truck engine", DetailType.Engine)
        {
            engineFactory = engine;
        }
    }
}