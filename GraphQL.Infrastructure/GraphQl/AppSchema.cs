 
using Microsoft.Extensions.DependencyInjection;
 
 

namespace GraphQL.Infrastructure.GraphQl
{
    public class AppSchema : Schema
    {
        public AppSchema(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<AppQuery>();
        }
    }
}
