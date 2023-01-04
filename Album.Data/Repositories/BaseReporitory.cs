using Album.Data.IRepositories;
using Album.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album.Data.Repositories
{
    public class BaseReporitory<T> : IBaseReporitory<T> where T : class
    {
        private readonly ChinookContext chinookContext;

        public BaseReporitory(ChinookContext chinookContext)
        {
            this.chinookContext = chinookContext;
        }

        public Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<T>> ListAllAsync(CancellationToken cancellationToken = default)
        {
            return await chinookContext.Set<T>().ToListAsync(cancellationToken);
        }

        public Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
