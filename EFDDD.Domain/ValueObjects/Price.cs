using System;
using System.Collections.Generic;
using System.Text;

namespace EFDDD.Domain.ValueObjects
{
    public sealed class Price : ValueObject<Price>
    {
        public Price(int value)
        {
            Value = value;
        }

        public int Value { get; }

        public override string ToString() => Value.ToString();
        public string DisplayValue => Value.ToString();
        public string DisplayValueUnit => Value + "円";

        protected override bool EqualsCore(Price other)
        {
            return Value == other.Value;
        }

        protected override int GetHashCodeCore()
        {
            return Value.GetHashCode();
        }
    }
}
