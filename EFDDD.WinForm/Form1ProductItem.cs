using EFDDD.Domain.Entities;
using EFDDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDDD.WinForm
{
    public sealed class Form1ProductItem
    {
        private ProductItemEntity _entity;

        public Form1ProductItem(ProductItemEntity entity)
        {
            _entity = entity;
        }

        public string ProductId => _entity.ProductId.DisplayValue;
        public string ProductItemNo => _entity.ProductItemNo.ToString();
        public string ProductItemName => _entity.ProductItemName;
        //public string Amount => _entity.Amount.ToString();
        //public string Currency => _entity.Currency;
        public string GlobalPrice => _entity.GlobalPrice.DisplayValue;
    }
}
