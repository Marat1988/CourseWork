using System;
using System.Collections.Generic;

namespace HostelStudent.Class
{
    public class Groups
    {
        public Groups()
        {
            this.Students = new HashSet<Students>();
            this.Users = new HashSet<Users>();
        }

        public int GroupId { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public virtual Departments Departments { get; set; }
        public virtual ICollection<Students> Students { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
