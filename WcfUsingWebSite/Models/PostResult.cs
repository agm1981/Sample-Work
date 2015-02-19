using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfUsingWebSite.Models
{
    public class PostResult
    {
        public override string ToString()
        {
            return Value;
        }

        public string Value
        {
            get;
            set;
        }
    }
}