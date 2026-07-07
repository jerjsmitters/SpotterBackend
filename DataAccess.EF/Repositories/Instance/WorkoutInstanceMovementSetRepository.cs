using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Domain.Instance;
using DataAccess.Repositories.Instance;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EF.Repositories.Instance
{
    public class WorkoutInstanceMovementSetRepository(EfDbContext context) : Repository(context), IWorkoutInstanceMovementSetRepository
    {
        public Task<List<WorkoutInstanceMovementSet>> GetAllAsync()
        {
            return Context.WorkoutInstanceMovementSets.ToListAsync();
        }

        public Task<WorkoutInstanceMovementSet?> GetByIdAsync(int id)
        {
            return Context.WorkoutInstanceMovementSets.FirstOrDefaultAsync(wims => wims.Id == id);
        }

        public async Task AddAsync(WorkoutInstanceMovementSet entity)
        {
            await Context.WorkoutInstanceMovementSets.AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(WorkoutInstanceMovementSet entity)
        {
            var existing = await Context.WorkoutInstanceMovementSets.FindAsync(entity.Id);
            if (existing == null)
            {
                throw new Exception($"Entity with ID {entity?.Id} does not exist.");
            }

            Context.Entry(existing).CurrentValues.SetValues(entity);
            await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(WorkoutInstanceMovementSet entity)
        {
            Context.WorkoutInstanceMovementSets.Remove(entity);
            await Context.SaveChangesAsync();
        }
    }
}
