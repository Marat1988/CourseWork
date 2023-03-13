using System;
using System.Collections.Generic;

namespace HostelStudent.Class
{
    public class Users
    {
        public Users()
        {
            this.Groups = new HashSet<Groups>();
        }

        public int UserId { get; set; }
        public string FullName { get; set; }
        public string TelNumber { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Groups> Groups { get; set; }
    }
}
