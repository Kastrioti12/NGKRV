using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    abstract class Twin:Room
    {
        public override void printRoom()
        {
            Console.WriteLine(idRoom + " " + empty + " -Twin Room");
        }
    }
}
