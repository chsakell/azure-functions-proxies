using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AzureFunctions.Autofac;
using Basket.API.Services;
using Basket.API.Model;
using System.Net.Http;

namespace Basket.API
{
    [DependencyInjectionConfig(typeof(DIConfig))]
    public static class DeleteBasket
    {
        [FunctionName("DeleteBasket")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "delete", Route = "baskets/{id}")] HttpRequestMessage req,
            [Inject]IInMemoryBasketRepository basketRepository,
            string id,
            ILogger log)
        {
            log.LogInformation("DeleteBasket function processed a request.");

            if (!Guid.TryParse(id, out var basketId))
                return new BadRequestObjectResult("Bad request");

            var customerBasket = await basketRepository.GetBasketAsync(basketId);

            if (customerBasket != null)
            {
                await basketRepository.DeleteBasketAsync(basketId);
                return new OkObjectResult("Basket deleted");
            }
            else
                return new NotFoundObjectResult("Basket not found");
        }
    }
}
