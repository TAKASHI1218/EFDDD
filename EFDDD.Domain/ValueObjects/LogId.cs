using System;
using System.Collections.Generic;
using System.Text;

namespace EFDDD.Domain.ValueObjects
{
    public sealed class LogId : ValueObject<LogId>
    {
        public LogId(long value)
        {
            Value = value;
        }

        public long Value { get; }

        public override string ToString() => Value.ToString();
        public string DisplayValue => Value.ToString().PadLeft(6, '0');

        protected override bool EqualsCore(LogId other)
        {
            return Value == other.Value;
        }

        protected override int GetHashCodeCore()
        {
            return Value.GetHashCode();
        }
    }
}
