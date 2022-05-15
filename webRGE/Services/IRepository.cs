using System.Collections.Generic;
using System.Threading.Tasks;
using webRGE.Entities.Base;

namespace webRGE.Services
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        int Add(T item);
        void Update(T item);
        bool Remove(int id);
        Task<bool> AddRange(IEnumerable<T> itemList);
        bool DeleteAll();
    }
}
