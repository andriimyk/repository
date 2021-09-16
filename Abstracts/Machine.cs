using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NUnit.Tests2.Abstracts
{
    public abstract class Machine
    {
        public List<DetailType> details = new List<DetailType>();
        public List<DetailType> addDetail(DetailType detail)
        {
            List< DetailType> details = new List<DetailType>();
            details.Add(detail);
            return details;
        }

        public Machine (List<DetailType> details)
        {
            this.details = details;
        }
    }
}
