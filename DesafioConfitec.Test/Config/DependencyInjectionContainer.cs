using DesafioConfitec.Business.Service;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioConfitec.Test.Config
{
    public class DependencyInjectionContainer
    {
        public static ServiceProvider GetServiceScopeFactory()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IOperacoesService, OperacoesService>();
            var Container = serviceCollection.BuildServiceProvider();

            return Container;
        }
    }
}