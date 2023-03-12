using System;
using System.Collections.Generic;

namespace HostelStudent.Class
{
    public class TypeRooms
    {
        public TypeRooms()
        {
            this.Rooms = new HashSet<Rooms>();
        }
        public int TypeRoomId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Rooms> Rooms { get; set; }
    }
}
