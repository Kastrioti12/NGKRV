using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{

    enum RoomView { Sea, Road, Garden };
    class Reservation 
    {
        //String NameOfGuest;
        int NumberOfRoom;
        public RoomView roomView;
        


        public Reservation( int roomNumber, RoomView _roomView)
        {
            
            NumberOfRoom = roomNumber;
            _roomView = roomView;
        }

        public void printReservation()
        {
            Console.WriteLine("Room number {0} is reserved under the name {1} with the view of {2}", NumberOfRoom, roomView);

        }

        public int getRoomNumber()
        {
            return NumberOfRoom;
        }
    }
}
