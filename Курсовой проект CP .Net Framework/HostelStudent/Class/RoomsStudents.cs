using System;
using System.Collections.Generic;

namespace HostelStudent.Class
{
    public class RoomsStudents
    {
        public int StudentId { get; set; }
        public int RoomId { get; set; }
        public DateTime DateSettlement { get; set; }

        public virtual Rooms Rooms { get; set; }
        public virtual Students Students { get; set; }
    }
}
