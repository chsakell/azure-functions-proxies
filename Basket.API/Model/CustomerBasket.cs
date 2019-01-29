using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.API.Model
{
    public class CustomerBasket
    {
        public Guid Id { get; set; }

        public List<BasketItem> Items { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        public CustomerBasket() { }
    }
}
