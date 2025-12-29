using EFDDD.Domain.Entities;
using EFDDD.Domain.Repositories;
using EFDDD.Domain.ValueObjects;
using EFDDD.Infrastructure;
using EFDDD.Infrastructure.EFCore;
using EFDDD.WinForm.VeiwModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.ComponentModel;

namespace EFDDD.WinForm
{
    public partial class Form1 : Form
    {
        private Form1ViewModel _vm = DI.Resolve<Form1ViewModel>();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

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
