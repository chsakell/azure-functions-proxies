using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using AzureFunctions.Autofac;
using Ordering.API.Services;

namespace Ordering.API
{
    [DependencyInjectionConfig(typeof(DIConfig))]
    public static class GetOrders
    {
        [FunctionName("GetOrders")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "orders")] HttpRequest req,
            [Inject]IOrderingService orderingService,
            ExecutionContext context,
            ILogger log)
        {
            log.LogInformation("GetOrders function processed a request.");

            await orderingService.Init(context);

            var orders = await orderingService.GetOrderAsync();

            return new OkObjectResult(orders);
        }
    }
}
