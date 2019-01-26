using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.API.Model
{
    public class OrderItem
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Units { get; set; }

        [JsonIgnore]
        public decimal DiscountedPrice
        {
            get
            {
                decimal discountedPrice = UnitPrice;

                if (Discount > 0 && Discount < 100)
                {
                    decimal markdown = Math.Round(UnitPrice * (Discount / 100m), 2, MidpointRounding.ToEven);
                    discountedPrice = UnitPrice - markdown;
                }
                return discountedPrice;
            }
            private set { }
        }
    }
}
