using Common.Dtos.ReferenceData;
using Common.Business;
using Business.Mapping.ReferenceData;
using DataAccess.Domain.ReferenceData;
using DataAccess.Repositories.ReferenceData;

namespace Business
{
    public class WorkoutTemplateService(IWorkoutTemplateRepository workoutTemplateRepository) : IWorkoutTemplateService
    {
        private readonly IWorkoutTemplateRepository repo = workoutTemplateRepository;

        public async Task<WorkoutTemplateDto?> GetByIdAsync(int id)
        {
            var result = await repo.GetByIdAsync(id);

            if (result == null)
            {
                return null;
            }


            return result.ToDto();
        }

        public async Task<List<WorkoutTemplateDto>> GetAllAsync()
        {
            var all = await repo.GetAllAsync();
            return all.ToDtos();
        }


        public async Task<WorkoutTemplateDto> CreateAsync(WorkoutTemplateDto dto)
        {
            var entity = dto.ToEntity();
            var savedEntity = await repo.AddAsync(entity);

            return savedEntity.ToDto();

        }

        public Task<WorkoutTemplateDto> UpdateAsync(WorkoutTemplateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            return repo.DeleteAsync(id);
        }

    }
}
