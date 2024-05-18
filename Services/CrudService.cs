using HRSystem.Database;
using HRSystem.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HRSystem.Services
{
    public class CrudService<T> : ICrud<T> where T : class
    {
        private readonly Connection context;

        public CrudService(Connection context)
        {
            this.context = context;

        }

        public async Task<T> Create(T entity)
        {
            var addedEntity = this.context.Set<T>().Add(entity).Entity;
            await this.context.SaveChangesAsync();
            return addedEntity;

        }

        public async Task<List<T>> Read()
        {
            return await this.context.Set<T>().ToListAsync();
        }
    }
}
