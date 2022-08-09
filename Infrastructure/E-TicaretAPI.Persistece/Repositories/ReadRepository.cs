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

        //Tacking: Verinin izlenmesi olayı.
        //Read işlemlerinde trackingi koparıyorrum çünkü sadece read yapacak veritabanında bir değişikliğe sebep olmayacak
        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking(); //Tacking koparma
            return query;
        }

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        // Marker Pattern => await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        //=> await Table.FindAsync(Guid.Parse(id));

        {
            var query = Table.AsQueryable();
            if(!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
           // IQueryable da findasync fonksiyonu olmadığı için marker desing pattern kullanmalıyız.
        }
        

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();//Task olmasına rağmen IQueryable dönüyor o yüzden AsQueryable ile yakalamam gerek
            if (!tracking)
                query = Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.Where(method);
            if(!tracking)
                query = query.AsNoTracking();
            return query;
        }
    }
}
