using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SampleApp.Application.Internal
{
    public static class ServiceExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}