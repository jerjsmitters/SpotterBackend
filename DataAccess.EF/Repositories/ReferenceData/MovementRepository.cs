using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Domain.ReferenceData;
using DataAccess.Repositories.ReferenceData;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EF.Repositories.ReferenceData
{
    public class MovementRepository(EfDbContext context) : Repository(context), IMovementRepository
    {
        public Task<List<Movement>> GetAllAsync()
        {
            return Context.Movements.ToListAsync();
        }

        public Task<Movement?> GetByIdAsync(int id)
        {
            return Context.Movements.FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task<Movement> AddAsync(Movement entity)
        {
            await Context.Movements.AddAsync(entity);
            await Context.SaveChangesAsync();

            return entity;
        }

        public async Task<Movement> UpdateAsync(Movement entity)
        {
            var existing = await Context.Movements.FindAsync(entity.Id);
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
            var entity = await Context.Movements.FirstOrDefaultAsync(m => m.Id == id);
            if (entity == null)
            {
                return;
            }

            Context.Movements.Remove(entity);
            await Context.SaveChangesAsync();
        }
    }
}
