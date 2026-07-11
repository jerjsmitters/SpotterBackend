using DataAccess.EF;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.EF.Setup
{
    public static class EfStartupExtensions
    {
        public static IServiceCollection InitialiseEF(this IServiceCollection services) 
        {
            services.AddDbContext<EfDbContext>();
            return services;
        }
    }
}
