using System;
using System.Collections.Generic;

#nullable disable

namespace MyShop
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            UsersRoles = new HashSet<UsersRole>();
        }

        public int UserId { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<UsersRole> UsersRoles { get; set; }
    }
}
