using Microsoft.EntityFrameworkCore;
using E_TicaretAPI.Application.Abstracture;
using E_TicaretAPI.Persistece.Concreate;
using E_TicaretAPI.Persistece.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretAPI.Persistece
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql("User ID=root;Password=myPassword;Host=localhost;Port=5432;Database=ETicaretAPIDb;"));
        }
    }
}
