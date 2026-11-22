using BusinessTrip.Application.Interfaces.Services;
using BusinessTrip.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTrip.Application.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this  IServiceCollection services)
        {
            services.AddScoped<IDestinationService, DestinationService>();

            return services;
        }
    }
}
