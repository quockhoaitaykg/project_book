using System;
using System.Collections.Generic;

#nullable disable

namespace BookManagementv2.Models
{
    public partial class Discount
    {
        public Discount()
        {
            Orders = new HashSet<Order>();
        }

        public string DiscountCode { get; set; }
        public string Description { get; set; }
        public int DiscountPercent { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
