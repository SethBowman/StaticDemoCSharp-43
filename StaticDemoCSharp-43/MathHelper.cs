using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemoCSharp_43
{
    public static class MathHelper
    {
        //static classes must have all static members
        public static int FixedNumber { get; set; }
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
