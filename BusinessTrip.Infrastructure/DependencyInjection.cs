using BusinessTrip.Application.Interfaces.Repositories;
using BusinessTrip.Infrastructure.Persistence;
using BusinessTrip.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace BusinessTrip.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {

            services.AddDbContext<BusinessTripDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("BusinessTripConnection")));

            services.AddScoped<IDestinationRepository,DestinationRepository>();
            return services;

        }
    }
}
