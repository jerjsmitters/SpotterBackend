using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Public
{
    public interface ICrudService<TDTO>
    {
        Task<IEnumerable<TDTO>> GetAllAsync();
        Task<TDTO?> GetByIdAsync(int id);
        Task<TDTO> CreateAsync(TDTO dto);
        Task<TDTO> UpdateAsync(TDTO dto);
        Task DeleteAsync(int id);
    }
}
