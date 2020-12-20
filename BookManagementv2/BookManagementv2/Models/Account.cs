using System;
using System.Collections.Generic;

#nullable disable

namespace BookManagementv2.Models
{
    public partial class Account
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int AccountStatus { get; set; }
        public int RoleId { get; set; }
        public string Fullname { get; set; }
        public DateTime? Birthday { get; set; }

        public virtual AccountStatus AccountStatusNavigation { get; set; }
        public virtual Role Role { get; set; }
    }
}
