using Business;
using Common.Business;
using Microsoft.Extensions.DependencyInjection;
using DataAccess.Setup;

namespace API
{
    internal static class StartupExtensions
    {
        public static void RegisterBusinessServices(this IServiceCollection services)
        {
            services.InitialiseORM();

            services.AddScoped<IConfiguredMovementService, ConfiguredMovementService>();
            services.AddScoped<IMovementConfigurationService, MovementConfigurationService>();
            services.AddScoped<IMovementService, MovementService>();
            services.AddScoped<IWorkoutInstanceMovementService, WorkoutInstanceMovementService>();
            services.AddScoped<IWorkoutInstanceMovementSetService, WorkoutInstanceMovementSetService>();
            services.AddScoped<IWorkoutInstanceService, WorkoutInstanceService>();
            services.AddScoped<IWorkoutTemplateService, WorkoutTemplateService>();
        }
    }
}

