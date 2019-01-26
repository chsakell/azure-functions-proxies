using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ordering.API.Model
{
    public class Order
    {
        public Guid Id { get; set; }
        public Address Address { get; set; }
        public List<OrderItem> Items { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total => GetTotal();

        public decimal GetTotal()
        {
            return Items.Sum(o => o.Units * o.DiscountedPrice);
        }
    }
}
