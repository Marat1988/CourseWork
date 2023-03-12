using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelStudent.Class
{
    public class Rooms
    {
        public Rooms()
        {
            this.RoomsStudents = new HashSet<RoomsStudents>();
        }

        public int RoomId { get; set; }
        public int TypeRoomId { get; set; }
        public string Number { get; set; }
        public int FloorApartment { get; set; }
        public int NumberBeds { get; set; }

        public virtual TypeRooms TypeRooms { get; set; }
        public virtual ICollection<RoomsStudents> RoomsStudents { get; set; }
    }
}
