using Autofac;
using AzureFunctions.Autofac.Configuration;
using Basket.API.Services;

public class DIConfig
{
    public DIConfig(string functionName)
    {
        DependencyInjection.Initialize(builder =>
        {
                builder.RegisterType<InMemoryBasketRepository>()
                .As<IInMemoryBasketRepository>().SingleInstance();
        }, functionName);
    }
}
