using EFDDD.Infrastructure.EFCore;

namespace EFDDD.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new AndersonDBContext())
            {
                dataGridView1.DataSource = context.Products.ToList();
            }

        }
    }
}
