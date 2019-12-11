using Microsoft.Extensions.DependencyInjection;
using SampleApp.Persistence.Infrastructure;

namespace SampleApp.Persistence.Internal
{
    public static class ServiceExtension
    {
        public static void AddPersistence(this IServiceCollection services)
        {
            services.AddScoped<SampleAppDbContext>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}