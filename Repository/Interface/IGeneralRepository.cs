using Repository.Class;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IGeneralRepository<T>
    {
        Task<GeneralResponse> Add(T item);
        Task<GeneralResponse> Edit(T item);
        Task<GeneralResponse> Delete(int id);
        Task<GeneralResponse> Delete(T entity);
        Task Save();
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
    }
}
