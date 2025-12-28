using EFDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDDD.Domain.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<ProductEntity> GetAll();
        void Add(ProductEntity entity);
        IEnumerable<ProductEntity> GetAllWithItems();
    }
}
