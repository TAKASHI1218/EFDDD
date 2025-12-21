using System;
using System.Collections.Generic;
using System.Text;

namespace EFDDD.Domain.ValueObjects
{
    public sealed class ProductId : ValueObject<ProductId>
    {
        public ProductId(int value)
        {
            Value = value;
        }

        public int Value { get; }

        public override string ToString() => Value.ToString();
        public string DisplayValue => Value.ToString().PadLeft(6, '0');

        protected override bool EqualsCore(ProductId other)
        {
            return Value == other.Value;
        }

        protected override int GetHashCodeCore()
        {
            return Value.GetHashCode();
        }
    }
}
