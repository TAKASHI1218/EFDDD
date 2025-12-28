using EFDDD.Domain.Entities;
using EFDDD.Domain.ValueObjects;
using EFDDD.Infrastructure;
using EFDDD.Infrastructure.EFCore;
using EFDDD.WinForm.VeiwModels;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace EFDDD.WinForm
{
    public partial class Form1 : Form
    {
        private Form1ViewModel _vm;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            var context = new AndersonDBContext();
            _vm = new Form1ViewModel(context,Factories.CreateProduct(context), Factories.CreateLog(context));

            ProductIdTextBox.DataBindings.Add("Text", _vm, nameof(_vm.ProductIdTextBoxText));
            ProductNameTextBox.DataBindings.Add("Text", _vm, nameof(_vm.ProductNameTextBoxText));
            PriceTextBox.DataBindings.Add("Text", _vm, nameof(_vm.PriceTextBoxText));         
            this.DataBindings.Add("Text", _vm, nameof(_vm.Title));

            dg1.DataSource = _vm.Products;
            SaveButton.Click += (_, __) => _vm.Save();
            dg1.SelectionChanged += (_, __) => _vm.dg1_SelectionChanged(dg1.CurrentRow.DataBoundItem as Form1Product);
            dg2.DataSource = _vm.ProductItems;
            LogDataGrid.DataSource = _vm.Logs;
        }
    }
}
