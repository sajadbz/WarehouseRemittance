using Microsoft.Extensions.DependencyInjection;
using System;
using WarehouseRemittance.Core.Services;

namespace WarehouseRemittance.IoC
{
    public class Container
    {
        private static ServiceCollection _services;
        private static ServiceProvider ServiceProvider;

        public ServiceProvider Register(ServiceCollection services = null)
        {
            if (_services == null)
                _services = new ServiceCollection();

            if (services != null)
                _services = services;

            ConfigureServices(_services);
            ServiceProvider = _services.BuildServiceProvider();

            return ServiceProvider;
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services
                .AddTransient<IWarehouseService, WarehouseService>()
                .AddTransient<IProductGroupService, ProductGroupService>()
            .AddTransient<IProductService, ProductService>()
            .AddTransient<IUserService, UserService>();

        }
    }
}
