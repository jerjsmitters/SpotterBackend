

using DataAccess.EF.Repositories.Instance;
using DataAccess.EF.Repositories.ReferenceData;
using DataAccess.Repositories.Instance;
using DataAccess.Repositories.ReferenceData;
using DataAccess.Setup;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Setup
{
    public static class BusinessStartupExtensions
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services) 
        {
            services.InitialiseORM();

            services.AddScoped<IConfiguredMovementRepository, ConfiguredMovementRepository>();
            services.AddScoped<IMovementRepository, MovementRepository>();
            services.AddScoped<IMovementConfigurationRepository, MovementConfigurationRepository>();
            services.AddScoped<IWorkoutTemplateRepository, WorkoutTemplateRepository>();

            services.AddScoped<IWorkoutInstanceRepository, WorkoutInstanceRepository>();
            services.AddScoped<IWorkoutInstanceMovementRepository, WorkoutInstanceMovementRepository>();
            services.AddScoped<IWorkoutInstanceMovementSetRepository, WorkoutInstanceMovementSetRepository>();

            return services;
        }
    }
}
