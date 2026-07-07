using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Domain.Instance;
using DataAccess.Repositories.Instance;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EF.Repositories.Instance
{
    public class WorkoutInstanceMovementRepository(EfDbContext context) : Repository(context), IWorkoutInstanceMovementRepository
    {
        public Task<List<WorkoutInstanceMovement>> GetAllAsync()
        {
            return Context.WorkoutInstanceMovements.ToListAsync();
        }

        public Task<WorkoutInstanceMovement?> GetByIdAsync(int id)
        {
            return Context.WorkoutInstanceMovements.FirstOrDefaultAsync(wim => wim.Id == id);
        }

        public async Task AddAsync(WorkoutInstanceMovement entity)
        {
            await Context.WorkoutInstanceMovements.AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(WorkoutInstanceMovement entity)
        {
            var existing = await Context.WorkoutInstanceMovements.FindAsync(entity.Id);
            if (existing == null)
            {
                throw new Exception($"Entity with ID {entity?.Id} does not exist.");
            }

            Context.Entry(existing).CurrentValues.SetValues(entity);
            await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(WorkoutInstanceMovement entity)
        {
            Context.WorkoutInstanceMovements.Remove(entity);
            await Context.SaveChangesAsync();
        }
    }
}
