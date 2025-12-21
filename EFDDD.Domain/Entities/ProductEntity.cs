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
            ProductId = productId;
            ProductName = productName;
            Price = new Price(price);
        }

        public int ProductId { get; }
        public string ProductName { get; private set; }
        public Price Price { get; }
    }
}
