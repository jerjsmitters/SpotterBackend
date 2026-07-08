using Business.Mapping;
using Business.Mapping.Instance;
using Business.Mapping.ReferenceData;
using Common.Business;
using Common.Dtos.Instance;
using Common.Dtos.ReferenceData;
using DataAccess.Domain.Instance;
using DataAccess.Domain.ReferenceData;
using DataAccess.Repositories.ReferenceData;
using DataAccess.Repositories.Instance;
using DataAccess.EF.Repositories.ReferenceData;
using DataAccess.EF.Repositories.Instance;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Setup
{
    public static class StartupExtensions
    {
        public static IServiceCollection RegisterMappers(this IServiceCollection services)
        {
            services.AddScoped<IMapper<WorkoutInstance, WorkoutInstanceDto>, WorkoutInstanceMapper>();
            services.AddScoped<IMapper<WorkoutInstanceMovement, WorkoutInstanceMovementDto>, WorkoutInstanceMovementMapper>();
            services.AddScoped<IMapper<WorkoutInstanceMovementSet, WorkoutInstanceMovementSetDto>, WorkoutInstanceMovementSetMapper>();

            services.AddScoped<IMapper<ConfiguredMovement, ConfiguredMovementDto>, ConfiguredMovementMapper>();
            services.AddScoped<IMapper<Movement, MovementDto>, MovementMapper>();
            services.AddScoped<IMapper<MovementConfiguration, MovementConfigurationDto>, MovementConfigurationMapper>();
            services.AddScoped<IMapper<WorkoutTemplate, WorkoutTemplateDto>, WorkoutTemplateMapper>();

            return services;

        }

        public static IServiceCollection RegisterRepositories(this IServiceCollection services) 
        {
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
