using Common.Dtos.ReferenceData;
using Common.Business;
using Business.Mapping.ReferenceData;
using DataAccess.Domain.ReferenceData;
using DataAccess.Repositories.ReferenceData;

namespace Business
{
    public class MovementService(IMovementRepository movementRepository) : IMovementService
    {
        private readonly IMovementRepository repo = movementRepository;

        public async Task<MovementDto?> GetByIdAsync(int id)
        {
            var result = await repo.GetByIdAsync(id);

            if (result == null)
            {
                return null;
            }

            return result.ToDto();
        }

        public async Task<List<MovementDto>> GetAllAsync()
        {
            var all = await repo.GetAllAsync();
            return all.ToDtos();
        }

        public async Task<MovementDto> CreateAsync(MovementDto dto)
        {
            var entity = dto.ToEntity();
            var saved = await repo.AddAsync(entity);
            return saved.ToDto();
        }

        public Task<MovementDto> UpdateAsync(MovementDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            return repo.DeleteAsync(id);
        }
    }
}
