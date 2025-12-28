using EFDDD.Domain.Entities;
using EFDDD.Domain.Repositories;
using EFDDD.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDDD.Infrastructure.EFCore
{
    internal sealed class ProductRepository : Repository<ProductEntity>,IProductRepository
    {



        public ProductRepository (AndersonDBContext context):base(context)
        {
        }

        public IEnumerable<ProductEntity> GetAllWithItems()
        {
            return _context.Products.Include(x => x.ProductItems).ToList();
        }
    }
}
