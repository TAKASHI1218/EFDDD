using EFDDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDDD.Domain.Entities
{
    public sealed class ProductItemEntity
    {
        private ProductItemEntity()
        {
            // ここに処理を書くのはOK
        }

        public ProductItemEntity(int productId, int productItemNo, string productItemName, decimal amount, string currency)
        {
            ProductId = new ProductId(productId);
            ProductItemNo = productItemNo;
            ProductItemName = productItemName;
            Amount = amount;
            Currency = currency;
        } 

        public ProductId ProductId { get; }
        public int ProductItemNo { get; private set; }
        public string ProductItemName { get; private set; }
        public decimal Amount { get; private set; }
        public string Currency { get; private set; }
        public ProductEntity Product { get; private set; }
    }
}
