using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnit.Tests2
{
    public class Body : BaseDetail
    {
        public string bodyFactory;
        public Body(string body) : base(body, DetailType.Body)
        {
            bodyFactory = body;
        }
    }
}