using EFDDD.Domain.Entities;
using EFDDD.Domain.Repositories;
using EFDDD.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace EFDDD.WinForm.VeiwModels
{
    public class Form1ViewModel : ViewModelBase
    {
        private IUnitOfWork _unitOfWork;

        public Form1ViewModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            foreach (var product in _unitOfWork.ProductRepository.GetAllWithItems())
            {
                Products.Add(new Form1Product(product));
            }

            foreach (var log in _unitOfWork.LogRepository.GetAll())
            {
                Logs.Add(log);
            }

        }

        public BindingList<Form1Product> Products { get; } = new();
        public BindingList<Form1ProductItem> ProductItems { get; } = new();
        public BindingList<LogEntity> Logs { get; } = new();


        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private string _productIdTextBoxText;
        public string ProductIdTextBoxText
        {
            get => _productIdTextBoxText;
            set => SetProperty(ref _productIdTextBoxText, value);
        }

        private string _priceTextBoxText;
        public string PriceTextBoxText
        {
            get => _priceTextBoxText;
            set => SetProperty(ref _priceTextBoxText, value);
        }

        private string _productNameTextBoxText;
        public string ProductNameTextBoxText
        {
            get => _productNameTextBoxText;
            set => SetProperty(ref _productNameTextBoxText, value);
        }

        public void Save()
        {
            int id = Convert.ToInt32(ProductIdTextBoxText);
            int price = Convert.ToInt32(PriceTextBoxText);
            var product = new ProductEntity(id, ProductNameTextBoxText, price);

            _unitOfWork.ProductRepository.Add(product);
            _unitOfWork.LogRepository.Add(new LogEntity(DateTime.Now, product.ProductName + "!!insert"));

            _unitOfWork.ExeSave();

            Title = "save!!";
        }

        public void dg1_SelectionChanged(Form1Product? dto)
        {
            ProductItems.Clear();
            if (dto == null)
            {
                return;
            }

            foreach (var val in dto.ProductItems)
            {
                ProductItems.Add(val);
            }
        }

    }
}
