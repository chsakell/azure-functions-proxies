using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.API.Model
{
    public enum OrderStatus
    {
        Submitted,
        AwaitingValidation,
        StockConfirmed,
        Paid,
        Shipped,
        Cancelled
    }
}
