using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Room
    {
        public int idRoom;
        public bool empty;

        public string IDRoom
        {
            get;
            set;
        }

        public Room()
        {
            this.idRoom = 0;

            this.empty = false;
        }
        public Room(int idRoom, bool empty)
        {
            this.idRoom = idRoom;
            this.empty = empty;

        }

        public bool isEmpty()
        {
            return empty;
        }
        public void setEmpty(bool empty)
        {
            this.empty = empty;
        }

        //Virtual methods are used when we expect from derived classes to change.
        public virtual void printRoom()
        {
            Console.WriteLine(idRoom + " " + empty);
        }
    }
}
