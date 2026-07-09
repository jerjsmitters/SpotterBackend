using Common.Dtos.Instance;
using Common.Business;
using Business.Mapping.Instance;
using DataAccess.Domain.Instance;
using DataAccess.Repositories.Instance;

namespace Business
{
    public class WorkoutInstanceService : IWorkoutInstanceService
    {
        private readonly IWorkoutInstanceRepository repo;

        public WorkoutInstanceService(IWorkoutInstanceRepository workoutInstanceRepository)
        {
            repo = workoutInstanceRepository;
        }

        public async Task<WorkoutInstanceDto?> GetByIdAsync(int id)
        {
            var result = await repo.GetByIdAsync(id);

            if (result == null)
            {
                return null;
            }

            return result.ToDto();
        }

        public async Task<List<WorkoutInstanceDto>> GetAllAsync()
        {
            var all = await repo.GetAllAsync();
            return all.ToDtos();
        }

        public Task<WorkoutInstanceDto> CreateAsync(WorkoutInstanceDto dto)
        {
            if (dto.Id is not null)
            {
                throw new Exception("Id must not be provided");
            }

            var entity = dto.ToEntity();
            return repo.AddAsync(entity).ContinueWith(t => t.Result.ToDto());
        }

        public Task<WorkoutInstanceDto> UpdateAsync(WorkoutInstanceDto dto)
        {
            if (dto.Id is null)
            {
                throw new Exception("Id must be provided");
            }

            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            return repo.DeleteAsync(id);
        }
    }
}
