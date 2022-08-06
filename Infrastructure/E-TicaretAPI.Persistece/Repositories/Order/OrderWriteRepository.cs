﻿using E_TicaretAPI.Application.Repositories;
using E_TicaretAPI.Domain.Entites;
using E_TicaretAPI.Persistece.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretAPI.Persistece.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
