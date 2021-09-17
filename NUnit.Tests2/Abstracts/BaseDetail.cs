using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnit.Tests2
{
    public abstract class BaseDetail
    {
        public string Name { get; set; }
        public DetailType Type { get; set; }

        public BaseDetail(string name, DetailType type) {
            Name = name;
            Type = type;
        }
    }
}