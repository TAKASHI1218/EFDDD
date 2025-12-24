using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EFDDD.Domain.ValueObjects
{
    public sealed class GlobalPrice : ValueObject<GlobalPrice>
    {
        public GlobalPrice(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public decimal Amount { get;  }
        public string Currency { get; }


        public string DisplayValue
        {
            get
            {
                if(Currency == "JPY")
                {
                    return decimal.Round(Amount) + "円";
                }
                else if(Currency == "USD")
                {
                    return "$" + Amount;
                }

                return "????" + Amount;
            }
        }
   
        protected override bool EqualsCore(GlobalPrice other)
        {
            return Amount == other.Amount && Currency == other.Currency;
        }

        protected override int GetHashCodeCore()
        {
            return HashCode.Combine(Amount,Currency);
        }
    }
}
