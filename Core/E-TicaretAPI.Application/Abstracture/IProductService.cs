using E_TicaretAPI.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretAPI.Application.Abstracture
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
