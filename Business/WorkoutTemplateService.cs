using Common.Dtos.ReferenceData;
using Common.Business;

namespace Business
{
    public class WorkoutTemplateService(IWorkoutTemplateService workoutTemplateService) : IWorkoutTemplateService
    {
        private readonly IWorkoutTemplateService workoutTemplateService = workoutTemplateService;
        

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

        public async Task<WorkoutTemplateDto?> GetByIdAsync(int id)
        {
            var result = await workoutTemplateService.GetByIdAsync(id);
            
            if (result == null)
            {
                return null;
            }


            throw new NotImplementedException();
        }

        public Task<WorkoutTemplateDto> UpdateAsync(WorkoutTemplateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
