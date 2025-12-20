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
        public Form1Product(ProductEntity entity)
        {
            _entity = entity;
        }

        public string ProductId => _entity.ProductId.ToString();
        public string ProductName => _entity.ProductName;
        public string Price => _entity.Price.DisplayValueUnit;
    }
}
