using Common.Dtos.Instance;
using Common.Business;
using Business.Mapping.Instance;
using DataAccess.Domain.Instance;
using DataAccess.Repositories.Instance;

namespace Business
{
    public class WorkoutInstanceMovementService(IWorkoutInstanceMovementRepository workoutInstanceMovementRepository) : IWorkoutInstanceMovementService
    {
        private readonly IWorkoutInstanceMovementRepository repo = workoutInstanceMovementRepository;

        public async Task<WorkoutInstanceMovementDto?> GetByIdAsync(int id)
        {
            var result = await repo.GetByIdAsync(id);

            if (result == null)
            {
                return null;
            }

            return result.ToDto();
        }

        public async Task<List<WorkoutInstanceMovementDto>> GetAllAsync()
        {
            var all = await repo.GetAllAsync();
            return all.ToDtos();
        }

        public async Task<WorkoutInstanceMovementDto> CreateAsync(WorkoutInstanceMovementDto dto)
        {
            var entity = dto.ToEntity();
            var saved = await repo.AddAsync(entity);
            return saved.ToDto();
        }

        public Task<WorkoutInstanceMovementDto> UpdateAsync(WorkoutInstanceMovementDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            return repo.DeleteAsync(id);
        }
    }
}
