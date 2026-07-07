using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Domain.ReferenceData;
using DataAccess.Repositories.ReferenceData;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EF.Repositories.ReferenceData
{
    public class ConfiguredMovementRepository(EfDbContext context) : Repository(context), IConfiguredMovementRepository
    {
        public Task<List<ConfiguredMovement>> GetAllAsync()
        {
            return Context.ConfiguredMovements.ToListAsync();
        }

        public Task<ConfiguredMovement?> GetByIdAsync(int id)
        {
            return Context.ConfiguredMovements.FirstOrDefaultAsync(cm => cm.Id == id);
        }

        public async Task AddAsync(ConfiguredMovement entity)
        {
            await Context.ConfiguredMovements.AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ConfiguredMovement entity)
        {
            var existingEntity = await Context.ConfiguredMovements.FindAsync(entity.Id);

            if (existingEntity == null)
            {
                throw new Exception($"Entity with ID {entity?.Id} does not exist.");
            }

            
        }

        public async Task DeleteAsync(ConfiguredMovement entity)
        {
            Context.ConfiguredMovements.Remove(entity);
            await Context.SaveChangesAsync();
        }
    }
}
