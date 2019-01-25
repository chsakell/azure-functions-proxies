using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Basket.API.Services;
using AzureFunctions.Autofac;

namespace Basket.API
{
    [DependencyInjectionConfig(typeof(DIConfig))]
    public static class GetBasket
    {
        [FunctionName("GetBasket")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "baskets/{id:guid}")] HttpRequest req,
            [Inject]IInMemoryBasketRepository basketRepository,
            string id,
            ILogger log)
        {
            log.LogInformation("GetBasket function processed a request.");

            if (!Guid.TryParse(id, out var basketId))
                return new BadRequestObjectResult("Bad request");

            var customerBasket = await basketRepository.GetBasketAsync(basketId);

            if (customerBasket != null)
                return new OkObjectResult(customerBasket);
            else
                return new NotFoundObjectResult("Basket not found");
        }
    }
}
