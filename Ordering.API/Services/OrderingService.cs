using Ordering.API.Model;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Azure.WebJobs;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;

namespace Ordering.API.Services
{
    public class OrderingService : IOrderingService
    {
        private static List<Order> _orders;
        private IExecutionContext _context;

        public List<Order> Orders
        {
            get
            {
                if (_orders == null)
                {
                    string ordersFile = Path.Combine(_context.FunctionAppDirectory, "orders.json");
                    string ordersJson = File.ReadAllText(ordersFile);

                    _orders = JsonConvert.DeserializeObject<List<Order>>(ordersJson);
                }

                return _orders;
            }
        }

        public Task<List<Order>> GetOrderAsync()
        {
            return Task.FromResult(Orders);
        }

        public Task<Order> GetOrderAsync(Guid id)
        {
            var order = Orders.FirstOrDefault(o => o.Id == id);

            return Task.FromResult(order);
        }

        public Task Init(ExecutionContext context)
        {
            _context = new FuncExecutionContext
            {
                InvocationId = context.InvocationId,
                FunctionAppDirectory = context.FunctionAppDirectory,
                FunctionDirectory = context.FunctionDirectory,
                FunctionName = context.FunctionName
            };

            return Task.CompletedTask;
        }

        public Task<Order> PlaceOrderAsync(Order order)
        {
            order.Id = Guid.NewGuid();
            order.OrderDate = DateTime.Now;

            _orders.Add(order);

            return Task.FromResult(order);
        }
    }
}
