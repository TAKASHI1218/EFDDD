using EFDDD.Domain.Entities;
using EFDDD.Domain.ValueObjects;
using EFDDD.Infrastructure.EFCore;
using System.ComponentModel;

namespace EFDDD.WinForm
{
    public partial class Form1 : Form
    {
        private BindingList<Form1Product> _products = new();


        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new AndersonDBContext())
            {
                foreach (var product in context.Products)
                {
                    _products.Add(new Form1Product(product));
                }

                dataGridView1.DataSource = _products;
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ProductIdTextBox.Text);
            int price = Convert.ToInt32(PriceTextBox.Text);
            var product = new ProductEntity(id, ProductNameTextBox.Text, price);

            using(var context = new AndersonDBContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }

            this.Text = "save!";
        }
    }
}
