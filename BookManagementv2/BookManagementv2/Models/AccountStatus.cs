using System;
using System.Collections.Generic;

#nullable disable

namespace BookManagementv2.Models
{
    public partial class AccountStatus
    {
        public AccountStatus()
        {
            Accounts = new HashSet<Account>();
        }

        public int AccountStatusId { get; set; }
        public string AccountStatus1 { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
