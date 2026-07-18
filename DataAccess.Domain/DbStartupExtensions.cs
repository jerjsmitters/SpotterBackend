using DataAccess.EF.Setup;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.ORM.Setup
{
    public static class DbStartupExtensions
    {
        public static IServiceCollection InitialiseORM(this IServiceCollection services, string connString)
        {
            //you can easily swap out the ORM used here
            services.InitialiseEF(connString);

            return services;
        }
    }
}
