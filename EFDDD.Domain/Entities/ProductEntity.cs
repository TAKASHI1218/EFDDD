using EFDDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDDD.Domain.Entities
{
    public sealed class ProductEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Price Price { get; set; }
    }
}
