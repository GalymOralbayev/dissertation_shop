using System.Collections.Generic;
using System.Threading.Tasks;
using Shop.DataAccess.Models;

namespace Shop.DataAccess {
    public interface IRecDataRepository
    {
        Task<IEnumerable<RecData>> GetAllAsync();
        Task AddRecDataAsync(RecData recData);
    }
}