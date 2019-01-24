using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Catalog.API.Model;
using System.Collections.Generic;

namespace Catalog.API
{
    public static class GetItems
    {
        [FunctionName("GetItems")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get",
            Route = "items")] HttpRequest req,
            ILogger log, ExecutionContext context)
        {
 
            string catalogItemsFile = Path.Combine(context.FunctionAppDirectory, "catalog.items.json");
            string itemsJson = File.ReadAllText(catalogItemsFile);

            var items = JsonConvert.DeserializeObject<List<CatalogItem>>(itemsJson);

            return new OkObjectResult(items);
                
        }
    }
}
