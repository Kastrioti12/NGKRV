using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        //singeltone controls currens access to the resource.
        // ensures that only one instance of a class exist.
        public static Singleton getInsance // static property to return a single instance of object.
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;

            }
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine("|Counter value"+counter.ToString());
        }
        public void printDetailes(string message)
        {
            Console.WriteLine(message);
        }
    }
}
