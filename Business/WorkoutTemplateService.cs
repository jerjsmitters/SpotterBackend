using Common.Dtos.ReferenceData;
using Common.Business;

namespace Business
{
    public class WorkoutTemplateService : IWorkoutTemplateService
    {
        public Task<WorkoutTemplateDto> CreateAsync(WorkoutTemplateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WorkoutTemplateDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<WorkoutTemplateDto?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<WorkoutTemplateDto> UpdateAsync(WorkoutTemplateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
