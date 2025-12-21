using EFDDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDDD.Domain.Entities
{
    public sealed class ProductEntity
    {
        private ProductEntity()
        {
            // ここに処理を書くのはOK
        }

        public ProductEntity(int productId, string productName, int price)
        {
            ProductId = new ProductId(productId);
            ProductName = productName;
            Price = new Price(price);
        }

        public ProductId ProductId { get; }
        public string ProductName { get; private set; }
        public Price Price { get; }
        public ICollection<ProductItemEntity> ProductItems { get; } = new List<ProductItemEntity>();
    }
}
