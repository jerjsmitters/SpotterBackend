

using Common.Business;
using Common.Dtos.ReferenceData;

namespace Business
{
    public class ConfiguredMovementService : IConfiguredMovementService
    {
        public Task<ConfiguredMovementDto> CreateAsync(ConfiguredMovementDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ConfiguredMovementDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ConfiguredMovementDto?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ConfiguredMovementDto> UpdateAsync(ConfiguredMovementDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
