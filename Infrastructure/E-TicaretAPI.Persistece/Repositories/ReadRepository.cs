using E_TicaretAPI.Application.Repositories;
using E_TicaretAPI.Domain.Entites.Common;
using E_TicaretAPI.Persistece.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretAPI.Persistece.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ETicaretAPIDbContext _context;
        
        public ReadRepository(ETicaretAPIDbContext context)
        {
            _context = context;
        }
        // EF Core,Set : Generic parametrede ki türe ait olabilecek DbContext nesneleri bize döndürecek metot
        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
        => Table;

        public async Task<T> GetByIdAsync(string id)
         => await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
        => await Table.FirstOrDefaultAsync(method);

        public IQueryable<T> GetWhere(System.Linq.Expressions.Expression<Func<T, bool>> method)
        => Table.Where(method);
    }
}
