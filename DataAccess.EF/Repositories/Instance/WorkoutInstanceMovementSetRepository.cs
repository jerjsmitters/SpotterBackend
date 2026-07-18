using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Domain.Instance;
using DataAccess.EF.DbContextImplementation;
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
        public async Task<WorkoutInstanceMovementSet> AddAsync(WorkoutInstanceMovementSet entity)
        {
            await Context.WorkoutInstanceMovementSets.AddAsync(entity);
            await Context.SaveChangesAsync();

            return entity;
        }

        public async Task<WorkoutInstanceMovementSet> UpdateAsync(WorkoutInstanceMovementSet entity)
        {
            var existing = await Context.WorkoutInstanceMovementSets.FindAsync(entity.Id);
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
            var entity = await Context.WorkoutInstanceMovementSets.FirstOrDefaultAsync(wims => wims.Id == id);
            if (entity == null)
            {
                return;
            }

            Context.WorkoutInstanceMovementSets.Remove(entity);
            await Context.SaveChangesAsync();
        }
    }
}
