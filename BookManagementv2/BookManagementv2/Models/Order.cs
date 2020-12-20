using System;
using System.Collections.Generic;

#nullable disable

namespace BookManagementv2.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public string Email { get; set; }
        public int OrderStatusId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOrder { get; set; }
        public string DiscountCode { get; set; }

        public virtual Discount DiscountCodeNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
