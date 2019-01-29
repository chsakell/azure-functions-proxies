using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.API.Model
{
    public class BasketItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
