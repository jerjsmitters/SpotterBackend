using Common.Dtos.ReferenceData;
using Common.Business;

namespace Business
{
    public class MovementConfigurationService : IMovementConfigurationService
    {
        public Task<MovementConfigurationDto> CreateAsync(MovementConfigurationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MovementConfigurationDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MovementConfigurationDto?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MovementConfigurationDto> UpdateAsync(MovementConfigurationDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
