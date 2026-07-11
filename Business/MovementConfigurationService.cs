using Common.Dtos.ReferenceData;
using Common.Business;
using Business.Mapping.ReferenceData;
using DataAccess.Domain.ReferenceData;
using DataAccess.Repositories.ReferenceData;

namespace Business
{
    public class MovementConfigurationService(IMovementConfigurationRepository movementConfigurationRepository) : IMovementConfigurationService
    {
        private readonly IMovementConfigurationRepository repo = movementConfigurationRepository;

        public async Task<MovementConfigurationDto?> GetByIdAsync(int id)
        {
            var result = await repo.GetByIdAsync(id);

            if (result == null)
            {
                return null;
            }

            return result.ToDto();
        }

        public async Task<List<MovementConfigurationDto>> GetAllAsync()
        {
            var all = await repo.GetAllAsync();
            return all.ToDtos();
        }

        public async Task<MovementConfigurationDto> CreateAsync(MovementConfigurationDto dto)
        {
            var entity = dto.ToEntity();
            var saved = await repo.AddAsync(entity);
            return saved.ToDto();
        }

        public Task<MovementConfigurationDto> UpdateAsync(MovementConfigurationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            return repo.DeleteAsync(id);
        }
    }
}
