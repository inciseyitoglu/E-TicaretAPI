using E_TicaretAPI.Application.Repositories;
using E_TicaretAPI.Domain.Entites;
using E_TicaretAPI.Persistece.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretAPI.Persistece.Repositories
{
    //ICustomerReadRepository CustomerRepositorynin imzasıdır.(Dependency Injectionda da bunun üzerinden çağırırım). ReadRepository ile de uygulanmış oluyor.
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
