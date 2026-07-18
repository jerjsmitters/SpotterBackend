using DataAccess;
using DataAccess.EF.Repositories.Instance;
using DataAccess.EF.Repositories.ReferenceData;
using DataAccess.EF.Setup;
using DataAccess.ORM.Setup;
using DataAccess.Repositories.Instance;
using DataAccess.Repositories.ReferenceData;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Setup
{
    public static class BusinessStartupExtensions
    {
        public static IServiceCollection InitialiseDataBase(this IServiceCollection services, string connString)
        {
            services.InitialiseORM(connString);
            return services;
        }
    }
}
