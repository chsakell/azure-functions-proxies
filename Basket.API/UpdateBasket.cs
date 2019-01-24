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
    public static class UpdateBasket
    {
        [FunctionName("UpdateBasket")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "put", Route = null)] HttpRequestMessage req,
            [Inject]IInMemoryBasketRepository basketRepository,
            ILogger log)
        {
            log.LogInformation("UpdateBasket function processed a request.");

            var basket = await req.Content.ReadAsAsync<CustomerBasket>();

            var customerBasket = await basketRepository.UpdateBasketAsync(basket);

            return new OkObjectResult(customerBasket);
        }
    }
}
