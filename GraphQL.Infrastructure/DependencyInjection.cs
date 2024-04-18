using GraphQL.Application.Interfaces;
using GraphQL.Infrastructure.GraphQl;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace GraphQL.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)//, IWebHostEnvironment environment)
        {
            services.AddDbContext<ApplicationContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("sqlConString"),
             b => b.MigrationsAssembly("GraphQL.Infrastructure")));

            services.AddGraphQLServer().AddQueryType<Query>().AddProjections().AddFiltering().AddSorting(); 
            services.AddScoped<IOwnerRepository, OwnerRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            return services;
        }
    }
}
