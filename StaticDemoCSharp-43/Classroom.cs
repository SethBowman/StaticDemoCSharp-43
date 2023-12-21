using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemoCSharp_43
{
    public class Classroom
    {
        //non static classes can have static members
        public static string Subject { get; set; }
        public int RoomNumber { get; set; }
    }
}
