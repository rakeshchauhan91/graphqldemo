using Microsoft.Extensions.DependencyInjection;

namespace GraphQL.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services )//, IWebHostEnvironment environment)
        {
            return services;
        }
    }
}
