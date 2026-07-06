using Common.Dtos.Instance;
using Common.Business;

namespace Business
{
    public class WorkoutInstanceService : IWorkoutInstanceService
    {
        public Task<WorkoutInstanceDto> CreateAsync(WorkoutInstanceDto dto)
        {
            if (dto.Id is not null)
            {
                throw new Exception("Id must not be provided");
            }

            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WorkoutInstanceDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<WorkoutInstanceDto?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<WorkoutInstanceDto> UpdateAsync(WorkoutInstanceDto dto)
        {
            if (dto.Id is null)
            {
                throw new Exception("Id must be provided");
            }

            throw new NotImplementedException();
        }
    }
}
