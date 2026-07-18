using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Domain.ReferenceData;
using DataAccess.EF.DbContextImplementation;
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
        public async Task<ConfiguredMovement> AddAsync(ConfiguredMovement entity)
        {
            await Context.ConfiguredMovements.AddAsync(entity);
            await Context.SaveChangesAsync();

            return entity;
        }

        public async Task<ConfiguredMovement> UpdateAsync(ConfiguredMovement entity)
        {
            var existing = await Context.ConfiguredMovements.FindAsync(entity.Id);
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
            var entity = await Context.ConfiguredMovements.FirstOrDefaultAsync(cm => cm.Id == id);
            if (entity == null)
            {
                return;
            }

            Context.ConfiguredMovements.Remove(entity);
            await Context.SaveChangesAsync();
        }
    }
}
