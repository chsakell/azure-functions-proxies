using Autofac;
using AzureFunctions.Autofac.Configuration;
using Microsoft.Azure.WebJobs;
using Ordering.API.Services;

namespace Ordering.API
{
    public class DIConfig
    {
        public DIConfig(string functionName)
        {
            DependencyInjection.Initialize(builder =>
            {
                builder.RegisterType<OrderingService>()
                        .As<IOrderingService>();
            }, functionName);
        }
    }
}
