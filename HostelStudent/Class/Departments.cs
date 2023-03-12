using System;
using System.Collections.Generic;

namespace HostelStudent.Class
{
    public class Departments
    {
        public Departments()
        {
            this.Groups = new HashSet<Groups>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Groups> Groups { get; set; }
    }
}
