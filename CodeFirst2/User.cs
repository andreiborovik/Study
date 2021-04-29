using System;
using System.Collections.Generic;

namespace CodeFirst2
{
    class User
    {
        public int UserId { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public List<Role> Roles { get; set; } = new List<Role>();

        public List<Orders> Orders { get; set; } = new List<Orders>();

    }
}
