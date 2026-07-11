

using Common.Business;
using Common.Dtos.ReferenceData;
using Business.Mapping.ReferenceData;
using DataAccess.Domain.ReferenceData;
using DataAccess.Repositories.ReferenceData;

namespace Business
{
    public class ConfiguredMovementService(IConfiguredMovementRepository configuredMovementRepository) : IConfiguredMovementService
    {
        private readonly IConfiguredMovementRepository repo = configuredMovementRepository;

        public async Task<ConfiguredMovementDto?> GetByIdAsync(int id)
        {
            var result = await repo.GetByIdAsync(id);

            if (result == null)
            {
                return null;
            }

            return result.ToDto();
        }

        public async Task<List<ConfiguredMovementDto>> GetAllAsync()
        {
            var all = await repo.GetAllAsync();
            return all.ToDtos();
        }

        public async Task<ConfiguredMovementDto> CreateAsync(ConfiguredMovementDto dto)
        {
            var entity = dto.ToEntity();
            var saved = await repo.AddAsync(entity);
            return saved.ToDto();
        }

        public Task<ConfiguredMovementDto> UpdateAsync(ConfiguredMovementDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            return repo.DeleteAsync(id);
        }
    }
}
