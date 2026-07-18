using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Domain.ReferenceData;
using DataAccess.EF.DbContextImplementation;
using DataAccess.Repositories.ReferenceData;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EF.Repositories.ReferenceData
{
    public class MovementConfigurationRepository(EfDbContext context) : Repository(context), IMovementConfigurationRepository
    {
        public Task<List<MovementConfiguration>> GetAllAsync()
        {
            return Context.MovementConfigurations.ToListAsync();
        }

        public Task<MovementConfiguration?> GetByIdAsync(int id)
        {
            return Context.MovementConfigurations.FirstOrDefaultAsync(mc => mc.Id == id);
        }
        public async Task<MovementConfiguration> AddAsync(MovementConfiguration entity)
        {
            await Context.MovementConfigurations.AddAsync(entity);
            await Context.SaveChangesAsync();

            return entity;
        }

        public async Task<MovementConfiguration> UpdateAsync(MovementConfiguration entity)
        {
            var existing = await Context.MovementConfigurations.FindAsync(entity.Id);
            if (existing == null)
            {
                throw new Exception($"Entity with ID {entity?.Id} does not exist.");
            }

            Context.Entry(existing).CurrentValues.SetValues(entity);
            await Context.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await Context.MovementConfigurations.FirstOrDefaultAsync(mc => mc.Id == id);
            if (entity == null)
            {
                return;
            }

            Context.MovementConfigurations.Remove(entity);
            await Context.SaveChangesAsync();
        }
    }
}
