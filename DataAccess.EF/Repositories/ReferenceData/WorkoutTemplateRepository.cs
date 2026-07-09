using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Domain.ReferenceData;
using DataAccess.Repositories.ReferenceData;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EF.Repositories.ReferenceData
{
    public class WorkoutTemplateRepository(EfDbContext context) : Repository(context), IWorkoutTemplateRepository
    {
        public Task<List<WorkoutTemplate>> GetAllAsync()
        {
            return Context.WorkoutTemplates.ToListAsync();
        }

        public Task<WorkoutTemplate?> GetByIdAsync(int id)
        {
            return Context.WorkoutTemplates.FirstOrDefaultAsync(wt => wt.Id == id);
        }
        public async Task<WorkoutTemplate> AddAsync(WorkoutTemplate entity)
        {
            await Context.WorkoutTemplates.AddAsync(entity);
            await Context.SaveChangesAsync();

            return entity;
        }

        public async Task<WorkoutTemplate> UpdateAsync(WorkoutTemplate entity)
        {
            var existing = await Context.WorkoutTemplates.FindAsync(entity.Id);
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
            var entity = await Context.WorkoutTemplates.FirstOrDefaultAsync(wt => wt.Id == id);
            if (entity == null)
            {
                return;
            }

            Context.WorkoutTemplates.Remove(entity);
            await Context.SaveChangesAsync();
        }
    }
}
