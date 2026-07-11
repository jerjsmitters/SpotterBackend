using Microsoft.Extensions.DependencyInjection;
using DataAccess.EF.Setup;

namespace DataAccess.Setup
{
    public static class DbStartupExtensions
    {
        public static IServiceCollection InitialiseORM(this IServiceCollection services)
        {
            services.InitialiseEF();

            return services;
        }
    }
}
