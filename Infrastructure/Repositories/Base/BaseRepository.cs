using Infrastructure.Context;
using Infrastructure.Models.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseClass
    {
        private readonly GUGContext context;
        private DbSet<T> entities;
        public BaseRepository(GUGContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public virtual async Task<IQueryable<T>> GetAllAsync()
        {
            return await Task.Run( () => entities.AsQueryable());
        }
        public async Task Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.CreationDate = DateTime.UtcNow;
            

            await entities.AddAsync(entity);
        }
        public async Task Commit()
        {
            await context.SaveChangesAsync();

        }
        public async Task Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.EditionDate = DateTime.UtcNow;

            await Task.Run(()=> context.Update(entity));
        }
        public async Task Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.IsDeleted = true;
            await Task.Run(() => context.Update(entity));

        }
        public async Task<T?> GetAsync(Guid id)
        {
            return await entities.FindAsync(id);
        }
    }
}
