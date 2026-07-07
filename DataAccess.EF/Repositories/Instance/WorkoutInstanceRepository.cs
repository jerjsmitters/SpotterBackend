using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Domain.Instance;
using DataAccess.Repositories.Instance;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EF.Repositories.Instance
{
    public class WorkoutInstanceRepository(EfDbContext context) : Repository(context), IWorkoutInstanceRepository
    {
        public Task<List<WorkoutInstance>> GetAllAsync()
        {
            return Context.WorkoutInstances.ToListAsync();
        }

        public Task<WorkoutInstance?> GetByIdAsync(int id)
        {
            return Context.WorkoutInstances.FirstOrDefaultAsync(wi => wi.Id == id);
        }

        public async Task AddAsync(WorkoutInstance entity)
        {
            await Context.WorkoutInstances.AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(WorkoutInstance entity)
        {
            var existing = await Context.WorkoutInstances.FindAsync(entity.Id);
            if (existing == null)
            {
                throw new Exception($"Entity with ID {entity?.Id} does not exist.");
            }

            Context.Entry(existing).CurrentValues.SetValues(entity);
            await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(WorkoutInstance entity)
        {
            Context.WorkoutInstances.Remove(entity);
            await Context.SaveChangesAsync();
        }
    }
}
