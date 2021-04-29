using System;
using System.Collections.Generic;

#nullable disable

namespace MyShop
{
    public partial class Role
    {
        public Role()
        {
            UsersRoles = new HashSet<UsersRole>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UsersRole> UsersRoles { get; set; }
    }
}
