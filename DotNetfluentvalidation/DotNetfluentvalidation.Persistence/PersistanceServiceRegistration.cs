using System;
using System.Collections.Generic;
using System.Text;
using DotNetfluentvalidation.Application.Services;
using DotNetfluentvalidation.Persistence.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetfluentvalidation.Persistence
{
    public static class PersistanceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<ITestService, TestService>();

            return services;
        }
    }
}
