using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    abstract class SuperiorRoom:Room //Polymorphisem duke perdorur tek klassa Room metoden virtual dhe duke e bere
        //override metoden printRoom ngjashem si tek \Room
    {
        public override void printRoom()
        {
            Console.WriteLine(idRoom + " " + empty + " -Superior Room");
        }
    }
}
