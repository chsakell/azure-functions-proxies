using Microsoft.Azure.WebJobs;
using Ordering.API.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.API.Services
{
    public interface IOrderingService
    {
        Task<Order> PlaceOrderAsync(Order order);
        Task<List<Order>> GetOrderAsync();
        Task<Order> GetOrderAsync(Guid id);
        Task Init(ExecutionContext context);
    }
}
