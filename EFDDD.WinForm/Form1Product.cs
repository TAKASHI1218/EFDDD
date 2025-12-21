using EFDDD.Domain.Entities;
using EFDDD.Domain.ValueObjects;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDDD.WinForm
{
    public sealed class Form1Product
    {
        private ProductEntity _entity;
        private List<Form1ProductItem> _items = new();

        public Form1Product(ProductEntity entity)
        {
            _entity = entity;

            foreach(var val in _entity.ProductItems)
            {
                _items.Add(new Form1ProductItem(val));
            }
        }

        public string ProductId => _entity.ProductId.DisplayValue;
        public string ProductName => _entity.ProductName;
        public string Price => _entity.Price.DisplayValueUnit;
        public ICollection<Form1ProductItem> ProductItems => _items;
    }
}
