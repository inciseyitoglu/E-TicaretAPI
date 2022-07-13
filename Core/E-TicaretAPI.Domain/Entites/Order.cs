using E_TicaretAPI.Domain.Entites.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretAPI.Domain.Entites
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public ICollection<Product> Products { get; set; }
        //Ef Core Customer'a karşılık default bir CustomerId oluşturulur manuel kontrol etmek için yukarıdaki gibi eklenebilir
        public Customer Customer { get; set; }
    }
}
  