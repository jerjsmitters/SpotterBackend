using Common.Dtos.Instance;
using Common.Business;
using Business.Mapping.Instance;
using DataAccess.Domain.Instance;
using DataAccess.Repositories.Instance;

namespace Business
{
    public class WorkoutInstanceMovementSetService(IWorkoutInstanceMovementSetRepository workoutInstanceMovementSetRepository) : IWorkoutInstanceMovementSetService
    {
        private readonly IWorkoutInstanceMovementSetRepository repo = workoutInstanceMovementSetRepository;

        public async Task<WorkoutInstanceMovementSetDto?> GetByIdAsync(int id)
        {
            var result = await repo.GetByIdAsync(id);

            if (result == null)
            {
                return null;
            }

            return result.ToDto();
        }

        public async Task<List<WorkoutInstanceMovementSetDto>> GetAllAsync()
        {
            var all = await repo.GetAllAsync();
            return all.ToDtos();
        }

        public async Task<WorkoutInstanceMovementSetDto> CreateAsync(WorkoutInstanceMovementSetDto dto)
        {
            var entity = dto.ToEntity();
            var saved = await repo.AddAsync(entity);
            return saved.ToDto();
        }

        public Task<WorkoutInstanceMovementSetDto> UpdateAsync(WorkoutInstanceMovementSetDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            return repo.DeleteAsync(id);
        }
    }
}
