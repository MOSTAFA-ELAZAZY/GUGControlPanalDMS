using Infrastructure.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Base
{
    public interface IBaseRepository<T> where T : BaseClass
    {
        Task<IQueryable<T>> GetAllAsync();
        Task<T?> GetAsync(Guid id);
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task Commit();
    }
}
