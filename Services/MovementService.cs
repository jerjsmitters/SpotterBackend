using DTOs.ReferenceData;

namespace Services.Public
{
    public class MovementService : IMovementService
    {
        public Task<MovementDto> CreateAsync(MovementDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MovementDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MovementDto?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MovementDto> UpdateAsync(MovementDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
