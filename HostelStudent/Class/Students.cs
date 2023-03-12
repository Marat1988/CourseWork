using System;
using System.Collections.Generic;

namespace HostelStudent.Class
{
    public class Students
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TelNumber { get; set; }
        public bool Sex { get; set; }
        public int GroupId { get; set; }

        public virtual Groups Groups { get; set; }
        public virtual RoomsStudents RoomsStudents { get; set; }
    }
}
